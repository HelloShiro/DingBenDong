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
    public partial class Form4 : Form
    {
        DataTable dt3 = new DataTable();
        SqlCommandBuilder cmdBuilder3;
        SqlConnection con = new SqlConnection("Data Source =\".\"; Initial Catalog = \"dingbendong\";Integrated Security = true;");
        SqlDataAdapter adapter3;
        DataTable dt4 = new DataTable();
        SqlCommandBuilder cmdBuilder4;
        SqlDataAdapter adapter4;
        private string clickedID;


        public Form4()
        {
            InitializeComponent();
        }
        private void GetData3(string selectCmd3)
        {
            dt3.Clear();
            adapter3 = new SqlDataAdapter(selectCmd3, con);
            cmdBuilder3 = new SqlCommandBuilder(adapter3);
            adapter3.Fill(dt3);
            dgv3.DataSource = dt3;
        }
        private void GetData4(string selectCmd4)
        {
            dt4.Clear();
            adapter4 = new SqlDataAdapter(selectCmd4, con);
            cmdBuilder4 = new SqlCommandBuilder(adapter4);
            adapter4.Fill(dt4);
            dgv4.DataSource = dt4;
        }

        //void checkPaid()
        //{
        //    foreach (DataGridViewRow row in dgv3.Rows)
        //    {
        //        if (row.Cells[0].Value.ToString()
        //            == cbStu.Text)
        //        {
        //            sameStu = true;
        //        }
        //    }
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select distinct StudentClass from Students where", con);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        cbClass.Items.Add(reader["StudentClass"].ToString());
        //    }
        //    reader.Close();
        //    con.Close();
        //}
        private void Form4_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (Form5.leastClicked)
            {
                btnKill.Visible = true;
                btnSave.Visible = true;
                btnKillStore.Visible = true;
                btnClass.Visible = true;
            }
            dgv3.AllowUserToAddRows = false;
            dgv4.AllowUserToAddRows = false;
            dgv3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GetData3("select distinct Orders.OrderID as 訂單編號,StudentClass as 班級, "+
                     "(select StoreName from Stores where Stores.StoreID = Orders.StoreID) as 店家名稱, "+
                     "(select StoreTel from Stores where Stores.StoreID = Orders.StoreID) as 店家電話, "+
                     "(select StudentName from Students where Students.StudentID = Orders.StarID) as 值日生, "+
                     "Orders.OrderDate as 訂購時間 from OrderDetails "+
                     "inner join Students on OrderDetails.StudentID = Students.StudentID "+
                     "inner join Orders on OrderDetails.OrderID = Orders.OrderID");
            dgv3.Columns[5].FillWeight = 180;

        }

        private void ExportExcel()
        {
            if (clickedID != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = clickedID.ToString() + "," + lblClass.Text + "," + lblStore.Text;
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
                    for (int i = 0; i < dgv4.ColumnCount; i++)
                    {
                        if (i > 0)
                        {
                            columnTitle += "\t";
                        }
                        columnTitle += dgv4.Columns[i].HeaderText;
                    }
                    sw.WriteLine(columnTitle);

                    for (int j = 0; j < dgv4.Rows.Count; j++)
                    {
                        string columnValue = "";
                        for (int k = 0; k < dgv4.Columns.Count; k++)
                        {
                            if (k > 0)
                            {
                                columnValue += "\t";
                            }
                            columnValue += dgv4.Rows[j].Cells[k].Value.ToString();
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
                }
            }
            else { MessageBox.Show("選擇班級"); }
            
        }
        void findStore()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StoreName from Stores where StoreID=(select StoreID from Orders where OrderID = "+ clickedID +")", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblStore.Text = reader["StoreName"].ToString();
            }
            con.Close();
            reader.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            if (clickedID != null)
            {
                DialogResult r;
                r = MessageBox.Show("本班所有訂單即將刪除,是否確認??", "刪除訂單", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    con.Open();
                    adapter4.DeleteCommand = con.CreateCommand();
                    string strSQL = "delete from OrderDetails where OrderID = " + clickedID;
                    adapter4.DeleteCommand.CommandText = strSQL;
                    adapter4.DeleteCommand.ExecuteNonQuery();
                    con.Close();
                    dt4.Clear();
                    cmdBuilder4 = new SqlCommandBuilder(adapter4);
                    adapter4.Fill(dt4);
                    dgv4.DataSource = dt4;
                }
            }
            else { MessageBox.Show("請選擇班級"); }
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Form5.leastClicked)
            {
                Application.Exit();
            }
        }

        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clickedID = dgv3.CurrentRow.Cells["訂單編號"].Value.ToString();
            GetData4("select OrderDetails.ProductName as 產品, Products.ProductPrice as 價格, " +
                     "sum(OrderDetails.Quantity) as 數量, OrderDetails.Discount as 折扣, " +
                     "sum(OrderDetails.Quantity) * Products.ProductPrice * OrderDetails.Discount as 總金額 from OrderDetails " +
                     "inner join Products on OrderDetails.ProductID = Products.ProductID " +
                     "where OrderID = " + clickedID + " group by OrderDetails.ProductName, Products.ProductPrice, OrderDetails.Discount");
            lblClass.Text = dgv3.CurrentRow.Cells["班級"].Value.ToString();
            findStore();
        }

        private void btnKillStore_Click(object sender, EventArgs e)
        {
            btnKillStore.Visible = false;
            cbStore.Visible = true;
            cbStore.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Stores", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbStore.Items.Add(reader["StoreName"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void cbStore_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("刪除店家後,所有訂購該店家之訂單將消失\n是否刪除?", "刪除店家", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string storeWillBeKill = cbStore.SelectedItem.ToString();
                con.Open();
                adapter3.DeleteCommand = con.CreateCommand();
                string strSQL = "delete from Stores where StoreName = N'" + storeWillBeKill +"'";
                adapter3.DeleteCommand.CommandText = strSQL;
                adapter3.DeleteCommand.ExecuteNonQuery();
                con.Close();
                dt3.Clear();
                cmdBuilder3 = new SqlCommandBuilder(adapter3);
                adapter3.Fill(dt3);
                dgv3.DataSource = dt3;
            }
            btnKillStore.Visible = true;
            cbStore.Visible = false;
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.FormClosed += new FormClosedEventHandler(Form6_FormClosed);
            form6.ShowDialog();
        }
        void Form6_FormClosed(object sender,FormClosedEventArgs e)
        {
            dt3.Clear();
            cmdBuilder3 = new SqlCommandBuilder(adapter3);
            adapter3.Fill(dt3);
            dgv3.DataSource = dt3;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.btnSub.Visible = true;
        }
    }
}
