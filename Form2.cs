using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dingbendong
{
    public partial class Form2 : Form
    {
        public int orderCount;
        SqlConnectionStringBuilder scsb;
        public string studentID = "";
        public string storeID = "";
        public string strStore = "";
        DataTable dt = new DataTable();
        SqlCommandBuilder cmdBuilder;
        SqlConnection con = new SqlConnection("Data Source =\".\";Initial Catalog = \"dingbendong\";Integrated Security = true;");
        SqlDataAdapter adapter;


        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();

            fillStudent();
            lblStore.Text = strStore;
            fillProduct();
            GetData("select OrderDetails.ProductName, Products.ProductPrice, Quantity , Products.ProductPrice*Quantity as SubTotal " +
                    "from OrderDetails inner join Products on OrderDetails.ProductID = Products.ProductID " +
                    "where OrderID = '" + orderCount + "' and StudentID = '" + studentID + "'");


            btnKillProducts.Enabled = false;
            btnUpdatePrice.Enabled = false;
            if (lblStudent.Text == Form1.strStar)
            {
                btnKillProducts.Enabled = true;
                btnUpdatePrice.Enabled = true;
            }
        }

        private void GetData(string strSQL)
        {

                dt.Clear();
                adapter = new SqlDataAdapter(strSQL, con);
                cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dt);
                dgv1.DataSource = dt;
                dgv1.AllowUserToAddRows = false;
                dgv1.Columns[0].ReadOnly = true;
                dgv1.Columns[1].ReadOnly = true;
                dgv1.Columns[2].ReadOnly = false;
                dgv1.Columns[2].ReadOnly = true;
                cal();
        }
        private void cal()
        {
            int intTotal = 0;
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                intTotal += Convert.ToInt32(row.Cells["SubTotal"].Value);
            }
            lblCal.Text = "小計: NT$" + intTotal.ToString();
        }


        private void ClearData()
        {
            tbProduct.Text = "";
            tbPrice.Text = "";
            cbQuantity.SelectedIndex = -1;
        }

        public void fillStudent()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StudentName from Students where StudentID = '" +
                studentID + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblStudent.Text= reader["StudentName"].ToString();
            }
            reader.Close();
            con.Close();
            
        }

        public void fillQuantity()
        {
            cbQuantity.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                cbQuantity.Items.Add(i);
            }
        }

        
        void fillProduct()
        {
            lbStore_products.Items.Clear();
            lbProduct_price.Items.Clear();
            tbProduct.Text = "";
            tbPrice.Text = "";
            con.Open();
            SqlCommand cmdProduct = new SqlCommand("select * from Products inner join Stores on " +
                "Products.StoreID = Stores.StoreID where StoreName = N'"+
                lblStore.Text+"'", con);
            SqlDataReader readerProduct = cmdProduct.ExecuteReader();
            while (readerProduct.Read())
            {
                lbStore_products.Items.Add(readerProduct["ProductName"].ToString());
                lbProduct_price.Items.Add(String.Format($"{readerProduct["ProductPrice"]:C0}"));
            }
            readerProduct.Close();
            con.Close();
        }

        private void lbStore_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbProduct.Text = lbStore_products.SelectedItem.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("select ProductPrice from Products where ProductName = N'" + lbStore_products.SelectedItem.ToString() + "'",con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbPrice.Text = reader["ProductPrice"].ToString();
                }
                con.Close();
                reader.Close();
            }
            catch (Exception)
            {
                con.Close();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool equal = false;

            if (tbProduct.Text.Length > 0 && cbQuantity.Text.Length > 0)
            {
                    for (int i = 0; i < dgv1.Rows.Count; i++)
                    {

                        if (dgv1.Rows[i].Cells[0].Value.ToString() == tbProduct.Text)
                        {
                            equal = true;
                            break;
                        }
                        continue;
                    }
                
                if (equal)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update OrderDetails set Quantity = @Quantity where StudentID = '"
                    + studentID + "' and ProductName = @Product", con);
                    int intAdd = Convert.ToInt32(cbQuantity.SelectedItem);
                    cmd.Parameters.AddWithValue("@Quantity", intAdd);
                    cmd.Parameters.AddWithValue("@Product", tbProduct.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearData();
                }
                else if (!equal)
                {
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("insert into OrderDetails(OrderID,ProductID,ProductName,StudentID,Quantity) " +
                            "values('" + orderCount + "', (select ProductID from Products where ProductName = N'" +
                            lbStore_products.SelectedItem.ToString() + "' and StoreID = '" + storeID + "'), N'" + lbStore_products.SelectedItem.ToString() +
                            "', '" + studentID + "', '" + cbQuantity.SelectedItem.ToString() + "')", con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        ClearData();
                }

                dt.Clear();
                cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Fill(dt);
                dgv1.DataSource = dt;
                lbStore_products.SelectedIndex = -1;
                cal();
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from OrderDetails where StudentID = @StudentID and ProductName = @ProductName", con);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@ProductName", dgv1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
                GetData("select OrderDetails.ProductName, Products.ProductPrice, Quantity ,Products.ProductPrice*Quantity as SubTotal " +
                        "from OrderDetails inner join Products on OrderDetails.ProductID = Products.ProductID " +
                        "where OrderID = '" + orderCount + "' and StudentID = '" + studentID + "'");

                cal();
            }
            catch (Exception)
            {
            }
                
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            bool sameProduct = false;
            for (int i = 0; i < lbStore_products.Items.Count; i++)
            {
                if (tbProduct.Text == lbStore_products.Items[i].ToString())
                {
                    sameProduct = true;
                }
            }
            bool ifNum = Int32.TryParse(tbPrice.Text, out int price);

            if (tbPrice.Text.Length>0 && tbProduct.Text.Length > 0 && !sameProduct && ifNum)
            {
                con.Open();
                string strSQL = "insert into Products(StoreID,ProductName,ProductPrice) values (@SearchStoreID,@SearchProductName,@SearchPrice)";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@SearchStoreID", storeID.ToString());
                cmd.Parameters.AddWithValue("@SearchProductName", tbProduct.Text);
                cmd.Parameters.AddWithValue("@SearchPrice", tbPrice.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"新增{rows.ToString()}筆產品");
                lbStore_products.Items.Clear();
                lbProduct_price.Items.Clear();
                fillProduct();

            }
            else if (sameProduct)
            {
                MessageBox.Show("重複產品");
            }
            else if (tbProduct.Text.Length <= 0)
            {
                MessageBox.Show("請輸入店家名稱");
            }
            else
            {
                MessageBox.Show("請輸入價格");
            }
            GetData("select OrderDetails.ProductName, Products.ProductPrice, Quantity ,Products.ProductPrice*Quantity as SubTotal " +
                    "from OrderDetails inner join Products on OrderDetails.ProductID = Products.ProductID " +
                    "where OrderID = '" + orderCount + "' and StudentID = '" + studentID + "'");
        }

        private void btnKillProducts_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("所有訂單中此產品將刪除,是否確認??", "刪除產品", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    con.Open();
                    string strSQL = "delete from Products where ProductName = N'" + tbProduct.Text + "'";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"刪除{rows.ToString()}筆產品");
                    lbStore_products.Items.Clear();
                    lbProduct_price.Items.Clear();
                    fillProduct();
                    GetData("select OrderDetails.ProductName, Products.ProductPrice, Quantity ,Products.ProductPrice*Quantity as SubTotal " +
                            "from OrderDetails inner join Products on OrderDetails.ProductID = Products.ProductID " +
                            "where OrderID = '" + orderCount + "' and StudentID = '" + studentID + "'");
                    cal();
                }
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Error404\n無法刪除\n原因:其他學員已選取此產品");
            }
            
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Products set ProductPrice = @ProductPrice where ProductName = N'"
                + tbProduct.Text + "'" , con);
            cmd.Parameters.AddWithValue("@ProductPrice", tbPrice.Text);
            int a = cmd.ExecuteNonQuery();
            MessageBox.Show($"修改{a}筆產品");
            con.Close();
            lbStore_products.Items.Clear();
            lbProduct_price.Items.Clear();
            fillProduct();
            GetData("select OrderDetails.ProductName, Products.ProductPrice, Quantity ,Products.ProductPrice*Quantity as SubTotal " +
                    "from OrderDetails inner join Products on OrderDetails.ProductID = Products.ProductID " +
                    "where OrderID = '" + orderCount + "' and StudentID = '" + studentID + "'");
            cal();
        }

        private void dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update OrderDetails set Quantity = @Quantity where StudentID = '"
                + studentID + "' and ProductName = @Product", con);
            cmd.Parameters.AddWithValue("@Quantity", dgv1.CurrentRow.Cells["Quantity"].Value.ToString());
            cmd.Parameters.AddWithValue("@Product", dgv1.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            GetData("select OrderDetails.ProductName, Products.ProductPrice, Quantity ,Products.ProductPrice*Quantity as SubTotal " +
                    "from OrderDetails inner join Products on OrderDetails.ProductID = Products.ProductID " +
                    "where OrderID = '" + orderCount + "' and StudentID = '" + studentID + "'");
            cal();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否保存訂單?","確認訂單", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Asterisk);
            if(result == DialogResult.No)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from OrderDetails where StudentID = @StudentID", con);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.ExecuteNonQuery();
                con.Close();
            }else if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else { }   
        }
    }
}
