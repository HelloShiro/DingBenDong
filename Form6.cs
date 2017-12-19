using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dingbendong
{
    public partial class Form6 : Form
    {
        DataTable dt5 = new DataTable();
        SqlCommandBuilder cmdBuilder5;
        SqlConnection con = new SqlConnection("Data Source =\".\"; Initial Catalog = \"dingbendong\";Integrated Security = true;");
        SqlDataAdapter adapter5;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            GetData5("select StudentID as 編號, StudentClass as 班級, StudentSeat as 座號, StudentName as 姓名, " +
                "StudentTel as 電話,  StudentNotes as 附註 from Students");
            dgv5.Sort(dgv5.Columns[0], ListSortDirection.Ascending);
            fillCbClass();
            dgv5.AllowUserToAddRows = false;
            dgv5.Columns[0].Visible = false;
        }
        private void GetData5(string selectCmd5)
        {
            dt5.Clear();
            adapter5 = new SqlDataAdapter(selectCmd5, con);
            cmdBuilder5 = new SqlCommandBuilder(adapter5);
            adapter5.Fill(dt5);
            dgv5.DataSource = dt5;
        }



        void fillCbClass()
        {
            cbClass.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select distinct StudentClass from Students", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbClass.Items.Add(reader["StudentClass"].ToString());
            }
            reader.Close();
            con.Close();
        }
        void fillCbStu()
        {
            cbStu.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Students where StudentClass = N'" + cbClass.SelectedItem.ToString() + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbStu.Items.Add(reader["StudentName"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void cbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillCbStu();
        }

        private void dgv5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbStu.Text = dgv5.CurrentRow.Cells["姓名"].Value.ToString();
            cbClass.Text = dgv5.CurrentRow.Cells["班級"].Value.ToString();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            bool sameStore = false;
            if (cbClass.Text.Length > 0)
            {
                for (int i = 0; i < cbClass.Items.Count; i++)
                {
                    if (cbClass.Text == cbClass.Items[i].ToString())
                    {
                        sameStore = true;
                    }
                }
                if (sameStore)
                {
                    bool sameStu = false;
                    if (cbStu.Text.Length > 0)
                    {
                        foreach (DataGridViewRow row in dgv5.Rows)
                        {
                            if (row.Cells[3].Value.ToString()
                                == cbStu.Text)
                            {
                                sameStu = true;
                            }
                        }
                        if (sameStu)
                        {
                            MessageBox.Show("已存在的學生");
                        }
                        else
                        {
                            try
                            {
                                con.Open();
                                adapter5.InsertCommand = con.CreateCommand();
                                string strSQL = "insert into Students(StudentClass,StudentSeat,StudentName,StudentTel,StudentNotes) values (N'" +
                                    cbClass.Text + "', '0' ,N'" + cbStu.Text + "',N'(電話)',N'(附註)')";
                                adapter5.InsertCommand.CommandText = strSQL;
                                adapter5.InsertCommand.ExecuteNonQuery();
                                con.Close();
                                dt5.Clear();
                                cmdBuilder5 = new SqlCommandBuilder(adapter5);
                                adapter5.Fill(dt5);
                                dgv5.DataSource = dt5;
                                MessageBox.Show("加入學生:" + cbStu.Text);

                                fillCbStu();
                            }
                            catch (Exception)
                            {
                                con.Close();
                                MessageBox.Show("重複的資料");
                            }

                        }
                        cbStu.Text = "";
                        cbClass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(" 歐布");
                    }
                    //MessageBox.Show("已存在的班級");
                }
                else
                {
                    con.Open();
                    adapter5.InsertCommand = con.CreateCommand();
                    string strSQL = "insert into Students(StudentClass,StudentSeat,StudentName,StudentTel,StudentNotes) values (N'" +
                        cbClass.Text + "', '0' , N'(姓名)',N'(電話)',N'(附註)')";
                    adapter5.InsertCommand.CommandText = strSQL;
                    adapter5.InsertCommand.ExecuteNonQuery();
                    con.Close();
                    dt5.Clear();
                    cmdBuilder5 = new SqlCommandBuilder(adapter5);
                    adapter5.Fill(dt5);
                    dgv5.DataSource = dt5;
                    fillCbClass();

                }
            }
            else
            {
                con.Close();
                MessageBox.Show("請填寫班級");
            }
            cbStu.Text = "";
            cbClass.Text = "";
        }

        private void btnKillClass_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("確認刪除班級??", "刪除班級", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                con.Open();
                adapter5.DeleteCommand = con.CreateCommand();
                string strSQL = "delete from Students where StudentClass = N'" + cbClass.Text + "'";
                adapter5.DeleteCommand.CommandText = strSQL;
                adapter5.DeleteCommand.ExecuteNonQuery();
                con.Close();
                dt5.Clear();
                cmdBuilder5 = new SqlCommandBuilder(adapter5);
                adapter5.Fill(dt5);
                dgv5.DataSource = dt5;
                MessageBox.Show("刪除班級:"+cbClass.Text);
                cbStu.Text = "";
                cbClass.Text = "";
            }
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKillStu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("確認刪除學員??", "刪除學員", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    con.Open();
                    adapter5.DeleteCommand = con.CreateCommand();
                    string strSQL = "delete from Students where StudentName = N'" + cbStu.Text + "'and StudentClass = N'"+ cbClass.Text+"'";
                    adapter5.DeleteCommand.CommandText = strSQL;
                    adapter5.DeleteCommand.ExecuteNonQuery();
                    con.Close();
                    dt5.Clear();
                    cmdBuilder5 = new SqlCommandBuilder(adapter5);
                    adapter5.Fill(dt5);
                    dgv5.DataSource = dt5;
                    MessageBox.Show("刪除學員:"+cbStu.Text);

                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("無此學員或無效的名稱");
            }
            cbStu.Text = "";
            cbClass.Text = "";

        }
        private void dgv5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int intSame = 0;
            int intNameSame = 0;
            foreach (DataGridViewRow row in dgv5.Rows)
            {
                if (row.Cells[1].Value.ToString()+row.Cells[2].Value.ToString()
                    ==dgv5.CurrentRow.Cells[1].Value.ToString()+dgv5.CurrentRow.Cells[2].Value.ToString())
                {
                    intSame++;
                }
                else if (row.Cells[1].Value.ToString() + row.Cells[3].Value.ToString()
                         == dgv5.CurrentRow.Cells[1].Value.ToString() + dgv5.CurrentRow.Cells[3].Value.ToString())
                {
                    intNameSame++;
                }
            }
            if (intSame >= 2)
            {
                MessageBox.Show("已存在的座號:" + dgv5.CurrentRow.Cells[2].Value.ToString());
            }else if (intNameSame >= 2)
            {
                MessageBox.Show("已存在的姓名:" + dgv5.CurrentRow.Cells[3].Value.ToString());
            }
            else
            {
                string strSQL = "";
                con.Open();
                adapter5.UpdateCommand = con.CreateCommand();
                if (e.ColumnIndex == 1)
                {
                    strSQL = "update Students set StudentClass = N'" +
                        dgv5.CurrentCell.Value.ToString() + "' where StudentID = N'" + dgv5.CurrentRow.Cells[0].Value.ToString() + "'";
                }
                else if (e.ColumnIndex == 2)
                {
                    strSQL = "update Students set StudentSeat = N'" +
                        dgv5.CurrentCell.Value.ToString() + "' where StudentID = N'" + dgv5.CurrentRow.Cells[0].Value.ToString() + "'";
                }
                else if (e.ColumnIndex == 3)
                {
                    strSQL = "update Students set StudentName = N'" +
                        dgv5.CurrentCell.Value.ToString() + "' where StudentID = N'" + dgv5.CurrentRow.Cells[0].Value.ToString() + "'";
                }
                else if (e.ColumnIndex == 4)
                {
                    strSQL = "update Students set StudentTel = N'" +
                        dgv5.CurrentCell.Value.ToString() + "' where StudentID = N'" + dgv5.CurrentRow.Cells[0].Value.ToString() + "'";
                }
                else if (e.ColumnIndex == 5)
                {
                    strSQL = "update Students set StudentNotes = N'" +
                        dgv5.CurrentCell.Value.ToString() + "' where StudentID = N'" + dgv5.CurrentRow.Cells[0].Value.ToString() + "'";
                }
                adapter5.UpdateCommand.CommandText = strSQL;
                adapter5.UpdateCommand.ExecuteNonQuery();
                con.Close();

            }
            dt5.Clear();
            cmdBuilder5 = new SqlCommandBuilder(adapter5);
            adapter5.Fill(dt5);
            dgv5.DataSource = dt5;
            fillCbClass();
            cbClass.Text = "";
            cbStu.Text = "";
        }
    }
}
