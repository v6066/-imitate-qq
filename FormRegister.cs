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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //注册
            //1.非空验证
            if(this.tx_zcuname.Text.Trim()=="")
            {
                MessageBox.Show("用户名不能为空");
                this.tx_zcuname.Text = "";
                this.tx_zcuname.Focus();
                return;
            }
            if (this.tx_zcupwd.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空");
                this.tx_zcupwd.Text = "";
                this.tx_zcupwd.Focus();
                return;
            }
            if (this.tx_pwd.Text.Trim() == "")
            {
                MessageBox.Show("确认码不能为空");
                this.tx_pwd.Text = "";
                this.tx_pwd.Focus();
                return;
            }

            //2.一致验证
            if(this.tx_pwd.Text.Trim()!=this.tx_zcupwd.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致");
                this.tx_pwd.Text = this.tx_zcupwd.Text = "";
                this.tx_zcupwd.Focus();
                return;
            }

            //3.注册
            frommain.zcUName = this.tx_zcuname.Text;
            frommain.zcUPwd=this.tx_zcupwd.Text;
            this.Close();
        }
    }
}
