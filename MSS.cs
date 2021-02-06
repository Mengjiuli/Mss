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
    public partial class Download : Form
    {
        public class Win32
        {
            public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口
            public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口
            public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口
            public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口
            public const Int32 AW_CENTER = 0x00000010; //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
            public const Int32 AW_HIDE = 0x00010000; //隐藏窗口，缺省则显示窗口。
            public const Int32 AW_ACTIVATE = 0x00020000; //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
            public const Int32 AW_SLIDE = 0x00040000; //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
            public const Int32 AW_BLEND = 0x00080000; //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(
          IntPtr hwnd, // handle to window 
              int dwTime, // duration of animation 
              int dwFlags // animation type 
              );
        }
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void Color1_MouseDown(object sender, MouseEventArgs e)
        {
            //拖动窗体
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        /*淡入窗体*/
        private void Download_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 100, Win32.AW_BLEND);
        }
        /*淡出窗体*/
        private void Download_Closing(object sender, FormClosingEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 200, Win32.AW_SLIDE | Win32.AW_HIDE | Win32.AW_BLEND);
        }

        const int CS_DropSHADOW = 0x20000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CS_DropSHADOW;
                return createParams;
            }
        }
        public Download()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private void Download_Button_Click(object sender, EventArgs e)
        {
            string ServerPath1 = "";
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Server_Ver.Text == "")
            {
                logs.Text = "请输入服务端版本";
            }
            else
            {
                R_Server_Path1.Description = "请选择保存到的目录";
                if (R_Server_Path1.ShowDialog() == DialogResult.OK)
                {
                    //记录选中的目录  
                    ServerPath1 = R_Server_Path1.SelectedPath;
                    Thread DownloadFiles = new Thread(new ThreadStart(Download));
                    DownloadFiles.Start();
                }
                else
                {
                    logs.Text = "请选择保存目录!";
                    return;
                }
            }
            void Download()
            {
                logs.Text = "下载时可能会出现卡顿，但都是正常现象，用时可能会较长";
                string url = "https://download.mcbbs.net/version/" + Server_Ver.Text + "/server";
                DateTime start = DateTime.Now;
                Uri uri = new Uri(url); 
                ServerPath1 = ServerPath1 + "\\" + Server_Ver.Text + "_Server.jar";
                //指定url 下载文件
                WebClient client = new WebClient();
                client.DownloadFile(url, ServerPath1);
                logs.Text = "下载成功,用时：" + (DateTime.Now - start).TotalSeconds + "秒,文件目录：" + ServerPath1;
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
        //窗口控件

        private void Start_Click(object sender, EventArgs e)
        {
            string ServerNP = "";

            string ServerName = Server_Name.Text;
            if (Server_Name.Text == "" || Max_v.Text == "" || GUI_yn.Text == "")
            {
                logs.Text = "有必填选项为空，请检查之后再重试！";
                return;
            }
            R_Server_Path1.Description = "请选择服务器目录";
            if (R_Server_Path1.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                string ServerPath2 = R_Server_Path1.SelectedPath;
                T_ServerPath2.Text = ServerPath2;
                logs.Text = ServerPath2;
            }
            else
            {
                logs.Text = "请选择保存目录!";
                return;
            }
            O_Server_Path1.Title = "请选择服务端目录";
            O_Server_Path1.Filter = "Jar文件(*.jar)|*.jar";
            if (O_Server_Path1.ShowDialog() == DialogResult.OK)
            {
                ServerNP = O_Server_Path1.FileName;
                T_ServerNP.Text = ServerNP;
            }
            else
            {
                logs.Text = "请选择文件目录!";
                return;
            }
            Thread CreateCmd = new Thread(new ThreadStart(Create));
            CreateCmd.Start();
        }
        private void Create()
        {
            string Gui_yn;
            String Path1 = logs.Text + "\\Start.bat";
            //创建StreamWriter 类的实例
            StreamWriter Writer1 = new StreamWriter(Path1);
            Writer1.WriteLine("@echo off");
            if(GUI_yn.Text == "Yes")
            {
                Gui_yn = "";
            }
            else
            {
                Gui_yn = "nogui";
            }
            Writer1.WriteLine("java -Xmx" + Max_v.Text + " -jar " + Server_Name.Text + " " + Gui_yn);
            Writer1.WriteLine("pause");
            //刷新缓存
            Writer1.Flush();
            //关闭流
            Writer1.Close();
            String Path2 = logs.Text + "\\eula.txt";
            //创建StreamWriter 类的实例
            StreamWriter Writer2 = new StreamWriter(Path2);
            Writer2.WriteLine("#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula).");
            Writer2.WriteLine("#Sat Jan 01 01:00:00 CST 2021");
            Writer2.WriteLine("eula=ture");
            //刷新缓存
            Writer2.Flush();
            //关闭流
            Writer2.Close();
            if (File.Exists(T_ServerPath2.Text + "\\" + Server_Name.Text))
            {

            }
            else
            {
                File.Move(T_ServerNP.Text, T_ServerPath2.Text);

            }
        }

        private void Server_Ver_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server_Name.Text = Server_Ver.Text + "_Server.jar";
        }
    }
}

