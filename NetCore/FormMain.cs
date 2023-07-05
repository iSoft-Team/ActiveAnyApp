using NetCore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetCore.AutoActive;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NetCore
{
    public partial class FormMain : Form
    {
        #region Singleton parttern
        private static FormMain _Instance = null;
        public static FormMain Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormMain();
                }
                return _Instance;
            }
        }
        //Form form = FormControl.Instance;
        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        AutoActive vietKey = new AutoActive();
        MQTTConfig mqttConfig = new MQTTConfig();
        IntPtr hWnd;

        public bool flag = false;

        private async void Form1_Load(object sender, EventArgs e)
        {
            mqttConfig.MQTT_Init(Settings.Default.address_broker, Settings.Default.port);
            mqttConfig.OnMqttPayloadReceive += _mqttClass_OnMqttPayloadReceive;
            mqttConfig.MQTTConnected += _mqttClass_Connected;
            mqttConfig.MQTTDisconnect += _mqttClass_Disconnected;
            mqttConfig.MQTTDisconnect += _mqttClass_Connecting;

            //this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
        }

        #region Event sub MQTT
        private Task _mqttClass_OnMqttPayloadReceive(string data)
        {
            return ReadMQTT_WriteDB(data);
        }
        public async Task ReadMQTT_WriteDB(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return;
            if (!flag)
            {
                flag = true;
                return;
            }
            txtData.Text = data;
            await FillOptel(data);
        }

        private async Task _mqttClass_Connected(string data)
        {
            await mqttConfig.Subcribe(Settings.Default.topic);
            lbNetwork.BackColor = Color.Green;
            lbNetwork.Text = "Network: Connect";
        }
        private Task _mqttClass_Disconnected(string data)
        {
            lbNetwork.BackColor = Color.Red;
            lbNetwork.Text = "Network: Disconnect";
            //return null;
            return Task.CompletedTask;
        }

        private Task _mqttClass_Connecting(string data)
        {
            lbNetwork.BackColor = Color.Orange;
            lbNetwork.Text = "Network: Connecting";
            return Task.CompletedTask;
        }
        #endregion

        public async Task FillOptel(string content)
        {
            BringAppToDesktop("Optel");

            hWnd = AutoActive.FindWindow(null, Settings.Default.caption_windown);
            if (hWnd != IntPtr.Zero)
            {
                lbStatus.BackColor = Color.Green;
                // Fill textbox
                {
                    var childhWnd = IntPtr.Zero;
                    childhWnd = AutoActive.FindWindowExFromParent(hWnd, null, Settings.Default.class_textbox);
                    AutoActive.SendText(childhWnd, content);
                }

                await Task.Delay(100);

                // Active button
                {
                    var childhWnd_Button = IntPtr.Zero;
                    childhWnd_Button = AutoActive.FindWindowExFromParent(hWnd, Settings.Default.caption_button, Settings.Default.class_button);
                    var pointToClick = AutoActive.GetGlobalPoint(childhWnd_Button, 0, 0);
                    AutoActive.BringToFront(hWnd);
                    AutoActive.MouseClick(pointToClick, AutoActive.EMouseKey.LEFT);
                }
            }
            else
            {
                //MessageBox.Show("Optel no open !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbStatus.BackColor = Color.Red;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            //SettingForm form_setting = new SettingForm();
            //form_setting.ShowDialog();
            FormLogin form_login = new FormLogin();
            this.Hide();
            form_login.ShowDialog();
            this.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {
            ReconnectAutoFill();
        }

        private async void lbNetwork_Click(object sender, EventArgs e)
        {
            await mqttConfig.MQTT_Init(Settings.Default.address_broker, Settings.Default.port);
        }

        private void timerCheckConnect_Tick(object sender, EventArgs e)
        {
            if (lbStatus.BackColor == Color.Red) ReconnectAutoFill();
        }

        public void ReconnectAutoFill()
        {
            hWnd = AutoActive.FindWindow(null, Settings.Default.caption_windown);
            if (hWnd != IntPtr.Zero)
            {
                lbStatus.BackColor = Color.Green;
                lbStatus.Text = "Status Optel: On";
            }
            else
            {
                lbStatus.BackColor = Color.Red;
                lbStatus.Text = "Status Optel: Off";
            }
        }







        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_FRAMECHANGED = 0x0020;

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static void BringAppToDesktop(string appName)
        {
            // Tìm cửa sổ chương trình thông qua tên lớp và tên cửa sổ
            IntPtr taskbarHwnd = FindWindow("Shell_TrayWnd", null);
            IntPtr taskbarRebarHwnd = FindWindowEx(taskbarHwnd, IntPtr.Zero, "ReBarWindow32", null);
            IntPtr trayNotifyHwnd = FindWindowEx(taskbarRebarHwnd, IntPtr.Zero, "TrayNotifyWnd", null);
            IntPtr sysPagerHwnd = FindWindowEx(trayNotifyHwnd, IntPtr.Zero, "SysPager", null);
            IntPtr notificationAreaHwnd = FindWindowEx(sysPagerHwnd, IntPtr.Zero, "ToolbarWindow32", null);

            IntPtr appHwnd = FindWindowEx(notificationAreaHwnd, IntPtr.Zero, null, appName);

            if (appHwnd != IntPtr.Zero)
            {
                // Lấy kích thước cửa sổ chương trình
                GetWindowRect(appHwnd, out RECT appRect);

                // Di chuyển cửa sổ chương trình từ taskbar lên desktop
                SetWindowPos(appHwnd, IntPtr.Zero, appRect.Left, appRect.Top, appRect.Right - appRect.Left, appRect.Bottom - appRect.Top, SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ứng dụng trên thanh taskbar.");
            }
        }









    }
}
