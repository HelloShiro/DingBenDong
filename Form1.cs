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
    public partial class Form1 : Form
    {
        public int orderIDCount;
        int orderIDMAX;
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();

        public int selectedIndex;
        SqlConnectionStringBuilder scsb;
        TimeSpan dateTimeNow;
        string choosedStore;
        bool starChoosed = false;
        
        static public string strStar;



        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            initPosition();
            lbStore_products.Items.Clear();
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "dingbendong";
            scsb.IntegratedSecurity = true;

            fillCbClass();
            initClass();
            timerTime.Interval = 33;
            timerTime.Enabled = true;
            form2.fillQuantity();
            btnChoose.Visible = false;
            btnMaintain.Visible = false;


        }
        void initPosition()
        {
            lblOr.Location = new Point(670, 320);
            lblOr.Font = new Font("微軟正黑體", 60, FontStyle.Bold);
            lblOr.Size = new Size(500, 300);
            lblOr.Visible = true;
            btnLeast.Location = new Point(500, 100);
            btnLeast.Font = new Font("微軟正黑體", 40, FontStyle.Bold);
            btnLeast.Size = new Size(500, 200);
            lblClass.Location = new Point(200, 450);
            lblClass.Font = new Font("微軟正黑體", 50, FontStyle.Bold);
            lblClass.Text = "選擇班級";
            cbClass.Location = new Point(540, 445);
            cbClass.Font = new Font("微軟正黑體", 50, FontStyle.Bold);
            cbClass.Size = new Size(750, 300);
        }


        void initClass()
        {
            foreach(Control c in Controls)
            {
                c.Visible = false;
            }
            lblClass.Visible = true;
            cbClass.Visible = true;
            btnLeast.Visible = true;
            lblOr.Visible = true;
            picIntro.Visible = true;
        }

        void classChoosed()
        {
            foreach (Control c in Controls)
            {
                c.Visible = true;
            }
            cbClass.Enabled = false;
            timerStar.Interval = 30000;
            timerStar.Enabled = true;   
        }
        void fillCbClass()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select distinct StudentClass from Students",con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbClass.Items.Add(reader["StudentClass"].ToString());
            }
            reader.Close();
            con.Close();
        }
        void fillLblStar()
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select top 1 StudentName from Students where StudentClass = N'" + cbClass.SelectedItem.ToString() + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblStar.Text = reader["StudentName"].ToString();
                strStar = lblStar.Text;
            }
            con.Close();
            reader.Close();
        }
        void filllblStoreChoosed()
        {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("select StoreName from Orders inner join Stores on " +
                    "Orders.StoreID = Stores.StoreID where OrderID = '" + orderIDCount + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    choosedStore = reader["StoreName"].ToString();
                }
                con.Close();
                reader.Close();
                lblStoreChoosed.Text = "已選擇: "+ choosedStore;

            
                form2.strStore = choosedStore;
                form3.strStoreName = choosedStore;
                if (choosedStore != null)
                {
                    starChoosed = true;
                    btnChoose.Text = "更改店家";
                }
                else
                {
                    btnChoose.Text = "選擇店家";
                }

        }


        void fillImage()
        {
            SqlConnection con_image = new SqlConnection(scsb.ToString());
            con_image.Open();
            SqlCommand cmd_image = new SqlCommand("select * from Stores where StoreName = N'" + lbStores.SelectedItem.ToString() + "'", con_image);
            SqlDataReader reader_image = cmd_image.ExecuteReader();
            while (reader_image.Read())
            {

                byte[] img;
                if (reader_image["StoreImage"] != DBNull.Value)
                {
                    img = (byte[])(reader_image["StoreImage"]);
                    MemoryStream ms = new MemoryStream(img);
                    image.Image = Image.FromStream(ms);
                }
                else
                {
                    image.Image = Image.FromFile("C:\\Users\\iii\\Desktop\\Dingbendong\\images\\snoopy.jpg");
                }

            }

            reader_image.Close();
            con_image.Close();
        }

        void fillLbStore()
        {
            SqlConnection con_fillLbStore = new SqlConnection(scsb.ToString());
            con_fillLbStore.Open();
            SqlCommand cmd_fillLbStore = new SqlCommand("select * from Stores", con_fillLbStore);
            SqlDataReader reader_fillLbStore = cmd_fillLbStore.ExecuteReader();
            while (reader_fillLbStore.Read())
            {
                lbStores.Items.Add(reader_fillLbStore["StoreName"].ToString());
            }
            reader_fillLbStore.Close();
            con_fillLbStore.Close();
        }
        void fillCbStore()
        {
            SqlConnection con_fillCbStore = new SqlConnection(scsb.ToString());
            con_fillCbStore.Open();
            SqlCommand cmd_fillCbStore = new SqlCommand("select * from Stores", con_fillCbStore);
            SqlDataReader reader_fillCbStore = cmd_fillCbStore.ExecuteReader();
            while (reader_fillCbStore.Read())
            {
                cbStore.Items.Add(reader_fillCbStore["StoreName"].ToString());
            }
            reader_fillCbStore.Close();
            con_fillCbStore.Close();
        }
        void fillCbType()
        {
            SqlConnection con_fillCbType = new SqlConnection(scsb.ToString());
            con_fillCbType.Open();
            SqlCommand cmd_fillCbType = new SqlCommand("select distinct(StoreType) from Stores", con_fillCbType);
            SqlDataReader reader_fillCbType = cmd_fillCbType.ExecuteReader();
            while (reader_fillCbType.Read())
            {
                cbType.Items.Add(reader_fillCbType["StoreType"].ToString());
            }
            reader_fillCbType.Close();
            con_fillCbType.Close();
        }

        private void cbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbStore_products.Items.Clear();
            lbProduct_price.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            SqlCommand cmd = new SqlCommand("select * from Products inner join Stores on " +
                "Products.StoreID = Stores.StoreID where StoreName = N'" + cbStore.SelectedItem.ToString() + "'", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string productName = reader["ProductName"].ToString();
                lbStore_products.Items.Add(productName);
                string productPrice = string.Format($"{reader["ProductPrice"]:C0}");
                lbProduct_price.Items.Add(productPrice);
            }
            reader.Close();

            try
            {
                SqlCommand cmd2 = new SqlCommand("select * from Stores where StoreName = N'" + cbStore.SelectedItem.ToString() + "'", con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string myStoreName = string.Format($"{reader2["StoreName"]}");
                    lblID.Text = string.Format($"{reader2["StoreID"]}");
                    tbAddress.Text = string.Format($"{reader2["StoreAddress"]}");
                    cbType.Text = reader2["StoreType"].ToString();
                    tbTel.Text = string.Format($"{reader2["StoreTel"]}");
                    tbNote.Text = string.Format($"{reader2["StoreNote"]}");
                    lbStores.SelectedIndex = lbStores.Items.IndexOf(myStoreName);
                }
                reader2.Close();
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void cbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbStore.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Stores where StoreType = N'" + cbType.SelectedItem.ToString() + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbStore.Items.Add(reader["StoreName"].ToString());
            }
            lblID.Text = "0";
            cbStore.Text = "";
            tbAddress.Text = "";
            tbNote.Text = "";
            tbTel.Text = "";
            lbProduct_price.Items.Clear();
            lbStore_products.Items.Clear();
            reader.Close();
            con.Close();
            lbStores.Items.Clear();
            fillLbStore();
            image.Image = Image.FromFile("C:\\Users\\iii\\Desktop\\Dingbendong\\images\\snoopy.jpg");
        }

        private void lbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbStore_products.Items.Clear();
                lbProduct_price.Items.Clear();
                SqlConnection con = new SqlConnection(scsb.ToString());
                SqlCommand cmd = new SqlCommand("select ProductName,ProductPrice from Products where StoreID = " + lblID.Text.ToString(), con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    lbStore_products.Items.Add(productName);
                    string productPrice = string.Format($"{reader["ProductPrice"]:C0}");
                    lbProduct_price.Items.Add(productPrice);
                }
                reader.Close();
                SqlCommand cmd2 = new SqlCommand("select * from Stores where StoreName = N'" + lbStores.SelectedItem.ToString() + "'", con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    string myStoreName = string.Format($"{reader2["StoreName"]}");
                    lblID.Text = string.Format($"{reader2["StoreID"]}");
                    cbStore.Text = reader2["StoreName"].ToString();
                    cbType.Text = reader2["StoreType"].ToString();
                    tbTel.Text = string.Format($"{reader2["StoreTel"]}");
                    tbAddress.Text = string.Format($"{reader2["StoreAddress"]}");
                    tbNote.Text = string.Format($"{reader2["StoreNote"]}");

                }
                reader2.Close();
                con.Close();
                fillImage();
            }
            catch (Exception)
            {
                MessageBox.Show("案太快嚕");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newStoreName = cbStore.Text;
            bool sameStore = false;
            for (int i = 0; i < lbStores.Items.Count; i++)
            {
                if (newStoreName == lbStores.Items[i].ToString())
                {
                    sameStore = true;
                }
            }
            if (cbStore.Text.Length > 0 && sameStore == false && cbType.Text.Length > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "insert into Stores values (@SearchType,@SearchStoreName,@SearchTel,@SearchAddress,@SearchNote,null)";
                SqlCommand cmd = new SqlCommand(strSQL, con);

                cmd.Parameters.AddWithValue("@SearchType", cbType.Text);
                cmd.Parameters.AddWithValue("@SearchStoreName", cbStore.Text);
                cmd.Parameters.AddWithValue("@SearchTel", tbTel.Text);
                cmd.Parameters.AddWithValue("@SearchAddress", tbAddress.Text);
                cmd.Parameters.AddWithValue("@SearchNote", tbNote.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增:共{rows.ToString()}筆");
                lbStores.Items.Clear();
                fillLbStore();
                cbStore.Items.Clear();
                fillCbStore();
            }
            else if (sameStore)
            {
                MessageBox.Show("請勿輸入重複店名");
            }
            else if (cbType.Text.Length <= 0)
            {
                MessageBox.Show("請選擇店家類型");
            }
            else
            {
                MessageBox.Show("請輸入店名");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);
            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = "update Stores set StoreType = @NewType," +
                    "StoreName = @NewStore, StoreTel = @NewTel" +
                    ",StoreAddress = @NewAddress, StoreNote = @NewNote, StoreImage = null" +
                    " where StoreID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", lblID.Text);
                cmd.Parameters.AddWithValue("@NewType", cbType.Text);
                cmd.Parameters.AddWithValue("@NewStore", cbStore.Text);
                cmd.Parameters.AddWithValue("@NewTel", tbTel.Text);
                cmd.Parameters.AddWithValue("@NewAddress", tbAddress.Text);
                cmd.Parameters.AddWithValue("@NewNote", tbNote.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(string.Format("資料異動完畢,共影響{0}筆資料", rows));
                lbStores.Items.Clear();
                fillLbStore();
                cbStore.Items.Clear();
                fillCbStore();
            }
            else
            {
                MessageBox.Show("程式設計師的錯誤");
            }
        }
        int count = 1;
        private void timerStar_Tick(object sender, EventArgs e)
        {
            int lastStudent = 0;
            SqlConnection con_changeStar = new SqlConnection(scsb.ToString());
            con_changeStar.Open();
            SqlCommand cmd_changeStar = new SqlCommand("select count(*) as lastStudent from Students where StudentClass = N'" + cbClass.SelectedItem.ToString() + "'", con_changeStar);
            SqlDataReader reader_changeStar = cmd_changeStar.ExecuteReader();
            while (reader_changeStar.Read())
            {
                lastStudent = Convert.ToInt32(reader_changeStar["lastStudent"])+1;
            }
            reader_changeStar.Close();

            if (count == lastStudent)
            {
                count = 1;
            }
            else
            {
                SqlCommand cmd_changeStar2 = new SqlCommand("select top " + count + "StudentName from Students where StudentClass = N'"+ cbClass.SelectedItem.ToString() +"'", con_changeStar);
                SqlDataReader reader_changeStar2 = cmd_changeStar2.ExecuteReader();
                while (reader_changeStar2.Read())
                {
                    lblStar.Text = reader_changeStar2["StudentName"].ToString();
                    strStar = lblStar.Text;
                }
                reader_changeStar2.Close();
                con_changeStar.Close();
                count++;
                try
                {
                    if (cbStudents.SelectedItem.ToString() == lblStar.Text)
                    {
                        btnChoose.Visible = true;
                        btnMaintain.Visible = true;
                    }
                    else
                    {
                        btnMaintain.Visible = false;
                        btnChoose.Visible = false;
                    }

                    chkStar.Enabled = true;
                    chkStar.Checked = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void cbStudents_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbStudents.SelectedItem.ToString() == lblStar.Text)
            {
                btnChoose.Visible = true;
                btnMaintain.Visible = true;
            }
            else
            {
                btnMaintain.Visible = false;
                btnChoose.Visible = false;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (cbStore.Text.Length > 0)
            {
                if (btnChoose.Text == "選擇店家")
                {
                    DialogResult storeConfirm;
                    storeConfirm = MessageBox.Show(cbStore.Text + " :\n\n謝謝您選擇我!!\n\n是否確定???\n\n ",
                        "店家確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (storeConfirm == DialogResult.Yes)
                    {
                        searchOrderMax();
                        orderIDMAX++;
                        orderIDCount = orderIDMAX;
                        form2.orderCount = orderIDCount;
                        form3.orderID = orderIDCount;
                        SqlConnection con2 = new SqlConnection(scsb.ToString());
                        con2.Open();
                        SqlCommand cmd2 = new SqlCommand("insert into Orders(OrderID,StoreID,StarID) values ('" +
                            orderIDMAX + "' ,'" + lblID.Text + "' ," +
                            "(select StudentID from Students where StudentName = N'" +
                            lblStar.Text + "'))", con2);
                        int row = cmd2.ExecuteNonQuery();
                        MessageBox.Show($"新增{row}筆訂單");
                        con2.Close();
                        filllblStoreChoosed();
                        starChoosed = true;
                    }
                }
                else if (btnChoose.Text == "更改店家")
                {
                    DialogResult storeConfirm;
                    storeConfirm = MessageBox.Show("本班所有訂單即將刪除,是否確認??", "更改訂單", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (storeConfirm == DialogResult.OK)
                    {
                        SqlConnection con = new SqlConnection(scsb.ToString());
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update Orders set StoreID = '" + lblID.Text + "', OrderDate = GETDATE() where OrderID = " + orderIDCount, con);
                        int row = cmd.ExecuteNonQuery();
                        SqlCommand cmd2 = new SqlCommand("delete from OrderDetails where OrderID =" + orderIDCount, con);
                        cmd2.ExecuteNonQuery();
                        con.Close();

                        filllblStoreChoosed();
                        starChoosed = true;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("請選擇店家");
            }

        }
        void searchOrderMax()
        {

            SqlConnection con3 = new SqlConnection(scsb.ToString());
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("select count(*) as c from Orders", con3);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                orderIDMAX = Convert.ToInt32(reader3["c"]);
            }
            reader3.Close();
            con3.Close();
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (cbStudents.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇名字");
            }
            else if (!starChoosed)
            {
                MessageBox.Show("等值日生選好");
            }
            else if (cbStudents.SelectedIndex >= 0 && choosedStore.Length > 0 && starChoosed)
            {
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("select StudentID from Students where StudentName = N'" +
                    cbStudents.Text + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    form2.studentID = reader["StudentID"].ToString();
                }
                reader.Close();

                SqlCommand cmd2 = new SqlCommand("select StoreID from Stores where StoreName = N'" +
                    choosedStore + "'", con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    form2.storeID = reader2["StoreID"].ToString();
                }
                reader2.Close();
                con.Close();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("例外狀況");
            }
        }
    

            
        

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            dateTimeNow = DateTime.Now.TimeOfDay;
            lblTimeNow.Text = "目前時間:" + dateTimeNow.ToString();

            TimeSpan timeCut = TimeSpan.Parse("23:59:00.520");
            lblCut.Text = "結單時間:" + timeCut.ToString();
            int time = TimeSpan.Compare(dateTimeNow, timeCut);
            if (time == 1)
            {
                btnSub.Visible = false;
            }
            else
            {
                btnSub.Visible = true;
            }
        }

        private void cbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Students where StudentClass = N'" + cbClass.SelectedItem.ToString() + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbStudents.Items.Add(reader["StudentName"].ToString());
            }
            reader.Close();

            SqlCommand cmd2 = new SqlCommand("select * from Students inner join Orders on Orders.StarID = Students.StudentID where StudentClass = N'" + cbClass.SelectedItem.ToString() + "'", con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                orderIDCount = Convert.ToInt32(reader2["OrderID"]);
            }
            reader2.Close();
            form2.orderCount = orderIDCount;
            form3.orderID = orderIDCount;

            con.Close();
            fillLblStar();
            classChoosed();
            fillLbStore();
            fillCbStore();
            fillCbType();
            filllblStoreChoosed();
            form3.stuClass = cbClass.SelectedItem.ToString();
            btnLeast.Visible = false;
            lblOr.Visible = false;
            picIntro.Visible = false;
            lblClass.Location = new Point(25, 20);
            lblClass.Text = "班級";
            cbClass.Size = new Size(123, 39);
            cbClass.Location = new Point(92, 16);
            cbClass.Font = new Font("微軟正黑體", 21, FontStyle.Bold);
            lblClass.Font = new Font("微軟正黑體", 21, FontStyle.Bold);

            btnMaintain.Visible = false;
            btnChoose.Visible = false;
            
        }

        private void chkStar_CheckedChanged(object sender, EventArgs e)
        {
            if(cbStudents.Text == "")
            {
                if(chkStar.Checked == false)
                {
                    MessageBox.Show("請自願當值日生");
                }
                
                chkStar.Checked = false;
            }
            else
            {
                lblStar.Text = cbStudents.SelectedItem.ToString();
                strStar = lblStar.Text;
                chkStar.Enabled = false;
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("update Orders set StarID = " +
                    "(select StudentID from Students where StudentName = N'"+
                    lblStar.Text + "') where OrderID = '" + orderIDCount+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            try
            {
                if (cbStudents.SelectedItem.ToString() == lblStar.Text)
                {
                    btnChoose.Visible = true;
                    btnMaintain.Visible = true;
                }
                else
                {
                    btnMaintain.Visible = false;
                    btnChoose.Visible = false;
                }
            }
            catch (Exception)
            {
            }
        }
        
        private void btnLeast_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.FormClosed += new FormClosedEventHandler(Form5_FormClosed);
            form5.ShowDialog();
        }
        void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Form5.ifLogin)
            {
            this.Hide();
            }
        }

        private void btnSeZtuMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("學員:\n1.待值日生選好店家 -> 訂購\n2.新增/修改店家\n值日生:\n1.選擇/更改店家\n2.管理當日訂單 ");
        }
    }
}
