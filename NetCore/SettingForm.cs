using NetCore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace NetCore
{
    public partial class SettingForm : Form
    {
        #region Singleton
        private static SettingForm _Instance = new SettingForm();
        public static SettingForm Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SettingForm();
                }
                return _Instance;
            }
        }
        #endregion

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            LoadDataSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.address_broker = txtAddressBroker.Text;
            Settings.Default.port = int.Parse(txtPort.Text);
            Settings.Default.topic = txtTopic.Text;
            Settings.Default.caption_windown = txtCaptionWindown.Text;
            Settings.Default.class_textbox = txtClassTextBox.Text;
            Settings.Default.class_button = txtClassButton.Text;
            Settings.Default.caption_button = txtCaptionButton.Text;
            Settings.Default.path_app_find_class = txtPath.Text;
            LoadDataSettings();
            MessageBox.Show("Settings is updated!", "Settings", MessageBoxButtons.OK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadDataSettings();
        }

        private void LoadDataSettings()
        {
            txtAddressBroker.Text = Settings.Default.address_broker;
            txtPort.Text = Settings.Default.port.ToString();
            txtTopic.Text = Settings.Default.topic;
            txtCaptionWindown.Text = Settings.Default.caption_windown;
            txtClassTextBox.Text = Settings.Default.class_textbox;
            txtClassButton.Text = Settings.Default.class_button;
            txtCaptionButton.Text = Settings.Default.caption_button;
            txtPath.Text = Settings.Default.path_app_find_class;
        }

        public void btnFind_Click(object sender, EventArgs e)
        {
            string pathToExe = Settings.Default.path_app_find_class;
            try
            {
                Process.Start(pathToExe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở app" + ex.Message);
            }

        }
    }
}
