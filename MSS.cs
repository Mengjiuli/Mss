using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace Minecraft_开服器
{
    public partial class Wds_Mss : Form
    {
        public Wds_Mss()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        public static string BoxState;
        //
        //
        private Form activeForm = null;
        public static int Tawsl = 1;
        public static int Back = 0;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Box.Controls.Add(childForm);
            Box.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Button_Home_Click(object sender, EventArgs e)
        {
            if (BoxState == "Home")
            {

            }
            else
            {
                OpenChildForm(new Wds_Home());
                BoxState = "Home";
            }
        }
        private void Button_Download_Click(object sender, EventArgs e)
        {
            if (BoxState == "Download")
            {

            }
            else
            {
                OpenChildForm(new Wds_Download());
                BoxState = "Download";
            }
        }
        private void Button_Info_Click(object sender, EventArgs e)
        {
            if (BoxState == "Info")
            {

            }
            else
            {
                OpenChildForm(new Wds_Info());
                BoxState = "Info";
            }
        }
        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            if(BoxState == "Settings")
            {

            }
            else
            {
                OpenChildForm(new Wds_Settings());
                BoxState = "Settings";
            }
        }
        //窗口控件
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //窗口动画
        public class Win32
        {
            public const Int32 AW_HOR_POSITIVE = 0x00000001; public const Int32 AW_HOR_NEGATIVE = 0x00000002; 
            public const Int32 AW_VER_POSITIVE = 0x00000004; public const Int32 AW_VER_NEGATIVE = 0x00000008; 
            public const Int32 AW_CENTER = 0x00000010; public const Int32 AW_HIDE = 0x00010000; 
            public const Int32 AW_ACTIVATE = 0x00020000; public const Int32 AW_SLIDE = 0x00040000; 
            public const Int32 AW_BLEND = 0x00080000; [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(IntPtr hwnd,int dwTime, int dwFlags );
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void Box_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void Wds_Mss_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 100, Win32.AW_BLEND);
        }

        private void Wds_Mss_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 100, Win32.AW_SLIDE | Win32.AW_HIDE | Win32.AW_BLEND);
            Tawsl = 0;
        }
    }
}

