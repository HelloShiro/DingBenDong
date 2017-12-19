using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dingbendong
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form4 form4 = new Form4();
        static public bool ifLogin = false;
        static public bool leastClicked = false;
        private void Form5_Load(object sender, EventArgs e)
        {
            tbAccount.Select();
            this.CenterToScreen();
            tbPassword.PasswordChar = '\u25CF';
            tbPassword.MaxLength = 12;
            

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            tbPassword.PasswordChar = '\0';
            //0929227368
            if (tbAccount.Text == "iii" && tbPassword.Text == "iii")
            {
                leastClicked = true;
                form4.Show();
                 
                this.Close();
                ifLogin = true;

            }
            else
            {
                MessageBox.Show("帳號密碼輸入錯誤");
                tbPassword.Text = "";
                tbPassword.PasswordChar = '\u25CF';
                tbPassword.MaxLength = 12;
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
