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
using System.IO;

namespace Dingbendong
{
    public partial class Form3 : Form
    {
        DataTable dt2 = new DataTable();
        SqlCommandBuilder cmdBuilder2;
        SqlConnection con = new SqlConnection("Data Source =\".\"; Initial Catalog = \"dingbendong\";Integrated Security = true;");
        SqlDataAdapter adapter2;
        Form4 form4 = new Form4();

        public int orderID;
        public string strStoreName;
        public string strYear, strMonth, strDay;
        public string stuClass;
        string stuAdd;
        Form2 form2 = new Form2();

        public Form3()
        {
            InitializeComponent();
        }
        private void GetData2(string selectCmd2)
        {
            dt2.Clear();
            adapter2 = new SqlDataAdapter(selectCmd2, con);
            cmdBuilder2 = new SqlCommandBuilder(adapter2);
            adapter2.Fill(dt2);
            dgv2.DataSource = dt2;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            GetData2("select Students.StudentName, OrderDetails.ProductName, Products.ProductPrice,"+
                     "OrderDetails.Quantity, OrderDetails.Discount, OrderDetails.Quantity * " +
                     "Products.ProductPrice*OrderDetails.Discount as Total, OrderDetails.Paid from OrderDetails " +
                     "inner join Students on OrderDetails.StudentID = Students.StudentID "+
                     "inner join Products on OrderDetails.ProductID = Products.ProductID where OrderDetails.OrderID = '"+ orderID.ToString()+"'");
            dgv2.AllowUserToAddRows = false;
            dgv2.Columns[0].ReadOnly = true;
            dgv2.Columns[1].ReadOnly = true;
            dgv2.Columns[2].ReadOnly = true;
            dgv2.Columns[3].ReadOnly = false;
            dgv2.Columns[4].ReadOnly = true;
            dgv2.Columns[5].ReadOnly = true;
            dgv2.Columns[6].ReadOnly = false;
            dgv2.Sort(dgv2.Columns[0],ListSortDirection.Ascending);
            try
            {
                cal();
            }
            catch (Exception)
            {
            }
            fillStuAndItems();
        }
        void kill()
        {

            con.Open();
            adapter2.DeleteCommand = con.CreateCommand();
            string strSQL = "delete from OrderDetails where OrderID = " + orderID;
            adapter2.DeleteCommand.CommandText = strSQL;
            adapter2.DeleteCommand.ExecuteNonQuery();
            con.Close();
            dt2.Clear();
            cmdBuilder2 = new SqlCommandBuilder(adapter2);
            adapter2.Fill(dt2);
            dgv2.DataSource = dt2;
            cal();
        }
   
        private void cal()
        {
            try
            {
                int intNotPaid = 0;
                int intTotal = 0;
                foreach (DataGridViewRow row in dgv2.Rows)
                {
                    intTotal += Convert.ToInt32(row.Cells["Total"].Value);
                    if (Convert.ToBoolean(row.Cells["Paid"].Value) == false)
                    {
                        intNotPaid += Convert.ToInt32(row.Cells["Total"].Value);
                    }
                }
                lblTotal.Text = "總計: NT$" + intTotal.ToString();
                lblNotPaid.Text = "待收款: NT$" + intNotPaid.ToString();
            }
            catch (Exception)
            {
            }
        }
        public void fillStuAndItems()
        {
            cbStu.Items.Clear();
            cbItems.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Students where StudentClass = N'" + stuClass + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbStu.Items.Add(reader["StudentName"].ToString());
            }
            reader.Close();
            SqlCommand cmd2 = new SqlCommand("select ProductName from Stores inner join Products on Stores.StoreID = Products.StoreID where StoreName = N'"+strStoreName+"'", con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                cbItems.Items.Add(reader2["ProductName"].ToString());
            }
            reader2.Close();
            con.Close();
        }


        void getOrderIDandStoreID()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select year(OrderDate) as y,month(OrderDate) as m, " +
                    "day(OrderDate) as d from Orders where OrderID = '"+orderID.ToString()+"'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    strYear = reader["y"].ToString();
                    strMonth = reader["m"].ToString();
                    strDay = reader["d"].ToString();
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
            
        }
        private void ExportExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = orderID.ToString()+ "," + strStoreName + ","+strYear+"-"+strMonth+"-"+strDay;
            saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "輸出excel文件";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName.IndexOf(":") < 0) return;
            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.Default);
            string columnTitle = "";
            try
            {
                for (int i = 0; i < dgv2.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        columnTitle += "\t";
                    }
                    columnTitle += dgv2.Columns[i].HeaderText;
                }
                sw.WriteLine(columnTitle);

                for (int j = 0; j < dgv2.Rows.Count; j++)
                {
                    string columnValue = "";
                    for (int k = 0; k < dgv2.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            columnValue += "\t";
                        }
                        columnValue += dgv2.Rows[j].Cells[k].Value.ToString();
                    }
                    sw.WriteLine(columnValue);
                }
                sw.Close();
                myStream.Close();
                MessageBox.Show("存檔完成");
            }
            catch (Exception e)
            {
                con.Close();
            }
            finally
            {
                sw.Close();
                myStream.Close();
                MessageBox.Show("存檔完成");
            }
        }

        private void dgv2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                con.Open();
                adapter2.UpdateCommand = con.CreateCommand();
                string strSQL = "update OrderDetails set Quantity =" + dgv2.CurrentCell.Value.ToString() +
                    " FROM Students INNER JOIN OrderDetails ON Students.StudentID = OrderDetails.StudentID " +
                    "WHERE StudentName = N'" + dgv2.Rows[e.RowIndex].Cells[0].Value.ToString() + "' AND " +
                    "ProductName = N'" + dgv2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";

                adapter2.UpdateCommand.CommandText = strSQL;
                adapter2.UpdateCommand.ExecuteNonQuery();
                con.Close();
                dt2.Clear();
                cmdBuilder2 = new SqlCommandBuilder(adapter2);
                adapter2.Fill(dt2);
                dgv2.DataSource = dt2;
                cal();

            }
            else if (e.ColumnIndex == 4)
            {
                con.Open();
                adapter2.UpdateCommand = con.CreateCommand();
                string strSQL = "update OrderDetails set Discount = " + dgv2.CurrentCell.Value.ToString() +
                    " FROM Students INNER JOIN OrderDetails ON Students.StudentID = OrderDetails.StudentID " +
                    "WHERE StudentName = N'" + dgv2.Rows[e.RowIndex].Cells[0].Value.ToString() + "' AND " +
                    "ProductName = N'" + dgv2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";

                adapter2.UpdateCommand.CommandText = strSQL;
                adapter2.UpdateCommand.ExecuteNonQuery();
                con.Close();
                dt2.Clear();
                cmdBuilder2 = new SqlCommandBuilder(adapter2);
                adapter2.Fill(dt2);
                dgv2.DataSource = dt2;
                cal();
            }
            else if (e.ColumnIndex == 6)
            {
                con.Open();
                adapter2.UpdateCommand = con.CreateCommand();
                string strSQL = "update OrderDetails set Paid = " + Convert.ToInt32(dgv2.CurrentCell.Value) +
                    " FROM Students INNER JOIN OrderDetails ON Students.StudentID = OrderDetails.StudentID " +
                    "WHERE StudentName = N'" + dgv2.Rows[e.RowIndex].Cells[0].Value.ToString() + "' AND " +
                    "ProductName = N'" + dgv2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                
                adapter2.UpdateCommand.CommandText = strSQL;
                adapter2.UpdateCommand.ExecuteNonQuery();
                con.Close();
                dt2.Clear();
                cmdBuilder2 = new SqlCommandBuilder(adapter2);
                adapter2.Fill(dt2);
                dgv2.DataSource = dt2;
                cal();
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            kill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getOrderIDandStoreID();
            ExportExcel();
        }

        private void cbStu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            stuAdd = cbStu.SelectedItem.ToString();
            cbItems.Visible = true;
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            con.Open();
            adapter2.UpdateCommand = con.CreateCommand();
            string strSQL = "update OrderDetails set Paid = 1 where orderID = " + orderID;
            adapter2.UpdateCommand.CommandText = strSQL;
            adapter2.UpdateCommand.ExecuteNonQuery();
            con.Close();
            dt2.Clear();
            cmdBuilder2 = new SqlCommandBuilder(adapter2);
            adapter2.Fill(dt2);
            dgv2.DataSource = dt2;
            cal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            cbStu.Visible = true;
        }

        private void cbItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string strItem = cbItems.SelectedItem.ToString();
            bool equal = false;
            for (int i = 0; i < dgv2.Rows.Count; i++)
            {
                if (dgv2.Rows[i].Cells[0].Value.ToString() == stuAdd && dgv2.Rows[i].Cells[1].Value.ToString() == strItem)
                {
                    equal = true;
                    break;
                }
                continue;
            }

            if (equal)
            {
                MessageBox.Show(stuAdd+"已訂購"+strItem);
            }
            else if (!equal)
            {
                con.Open();
                adapter2.InsertCommand = con.CreateCommand();
                string strSQL = "insert into OrderDetails(OrderID,ProductID,StudentID,ProductName,Quantity) values (" + orderID + ", (select ProductID from Products inner join Stores on Products.StoreID = Stores.StoreID where ProductName = N'" + strItem + "' and StoreName = N'" + strStoreName + "')," +
                    "(select StudentID from Students where StudentName = N'" + stuAdd + "'), N'" + strItem + "', 1)";
                adapter2.InsertCommand.CommandText = strSQL;
                adapter2.InsertCommand.ExecuteNonQuery();
                con.Close();
                dt2.Clear();
                cmdBuilder2 = new SqlCommandBuilder(adapter2);
                adapter2.Fill(dt2);
                dgv2.DataSource = dt2;
                cal();
            }
            cbItems.Visible = false;
            cbStu.Visible = false;
            btnAdd.Visible = true;
            cbStu.SelectedIndex = -1;
            cbItems.SelectedIndex = -1;

        }

        private void btnKakuNin_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }
    }
}
