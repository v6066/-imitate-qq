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
    public partial class frommain : Form
    {
        public static string zcUName, zcUPwd;
        public static bool isLoginOk = false;

        public frommain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //打开登录窗
            Formlogin myform = new Formlogin();
            myform.ShowDialog();

            //判断是否登录进入这里
            if (isLoginOk == false)
            {
                this.Close();
            }
            else
            {
                this.lb_name.Text = zcUName;
            }
        }
      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
