using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿QQ登录
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister myform = new FormRegister();
            myform.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.textBox_name.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空");
                this.textBox_name.Text = "";
                this.textBox_name.Focus();
                return;
            }
            if (this.textBox_pwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空");
                this.textBox_pwd.Text = "";
                this.textBox_pwd.Focus();
                return;
            }

            if(this.textBox_name.Text.Trim()==frommain.zcUName&&this.textBox_pwd.Text.Trim()==frommain.zcUPwd)
            {
                //close
                frommain.isLoginOk = true;
                this.Close();
            }
            else
            {
                //error
                MessageBox.Show("用户名或密码输入有误！");
                this.textBox_pwd.Text = "";
                this.textBox_pwd.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
