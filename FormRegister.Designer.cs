
namespace 仿QQ登录
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.tx_zcupwd = new System.Windows.Forms.TextBox();
            this.tx_zcuname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_pwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_zcupwd
            // 
            this.tx_zcupwd.Font = new System.Drawing.Font("宋体", 12F);
            this.tx_zcupwd.Location = new System.Drawing.Point(361, 146);
            this.tx_zcupwd.Name = "tx_zcupwd";
            this.tx_zcupwd.PasswordChar = '*';
            this.tx_zcupwd.Size = new System.Drawing.Size(265, 30);
            this.tx_zcupwd.TabIndex = 4;
            // 
            // tx_zcuname
            // 
            this.tx_zcuname.Font = new System.Drawing.Font("宋体", 12F);
            this.tx_zcuname.Location = new System.Drawing.Point(361, 76);
            this.tx_zcuname.Name = "tx_zcuname";
            this.tx_zcuname.Size = new System.Drawing.Size(265, 30);
            this.tx_zcuname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(42, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(42, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F);
            this.label3.Location = new System.Drawing.Point(42, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "请再次输入密码：";
            // 
            // tx_pwd
            // 
            this.tx_pwd.Font = new System.Drawing.Font("宋体", 12F);
            this.tx_pwd.Location = new System.Drawing.Point(361, 211);
            this.tx_pwd.Name = "tx_pwd";
            this.tx_pwd.PasswordChar = '*';
            this.tx_pwd.Size = new System.Drawing.Size(265, 30);
            this.tx_pwd.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_pwd);
            this.Controls.Add(this.tx_zcupwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_zcuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_zcupwd;
        private System.Windows.Forms.TextBox tx_zcuname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_pwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}