using NetCore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace NetCore
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = Settings.Default.name_login.Trim();
            string pass = Settings.Default.pass.Trim();
            if (txtAccount.ToString() == "" || txtPass.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản và mật khẩu");
                return;
            }
            if (txtAccount.Text.Trim() == account && txtPass.Text.Trim() == pass)
            {
                SettingForm form_setting = new SettingForm();
                this.Hide();
                form_setting.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
                return;
            }
        }
    }
}
