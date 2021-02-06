
namespace Minecraft_开服器
{
    partial class Download
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Box1 = new System.Windows.Forms.Panel();
            this.GUI_yn = new System.Windows.Forms.ComboBox();
            this.T_GUI_yn = new System.Windows.Forms.Label();
            this.Max_v = new System.Windows.Forms.TextBox();
            this.T_Max_v = new System.Windows.Forms.Label();
            this.Server_Name = new System.Windows.Forms.TextBox();
            this.T_Server_Name = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Server_Ver = new System.Windows.Forms.ComboBox();
            this.B_Download = new System.Windows.Forms.Button();
            this.A_Server_Ver = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.TextBox();
            this.R_Server_Path1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Color1 = new System.Windows.Forms.Panel();
            this.T_FormNmae = new System.Windows.Forms.Label();
            this.Mini = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.R_Server_Path2 = new System.Windows.Forms.FolderBrowserDialog();
            this.O_Server_Path1 = new System.Windows.Forms.OpenFileDialog();
            this.T_ServerPath2 = new System.Windows.Forms.TextBox();
            this.T_ServerNP = new System.Windows.Forms.TextBox();
            this.Box1.SuspendLayout();
            this.Color1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.White;
            this.Box1.Controls.Add(this.T_ServerNP);
            this.Box1.Controls.Add(this.T_ServerPath2);
            this.Box1.Controls.Add(this.GUI_yn);
            this.Box1.Controls.Add(this.T_GUI_yn);
            this.Box1.Controls.Add(this.Max_v);
            this.Box1.Controls.Add(this.T_Max_v);
            this.Box1.Controls.Add(this.Server_Name);
            this.Box1.Controls.Add(this.T_Server_Name);
            this.Box1.Controls.Add(this.Start);
            this.Box1.Controls.Add(this.Server_Ver);
            this.Box1.Controls.Add(this.B_Download);
            this.Box1.Controls.Add(this.A_Server_Ver);
            this.Box1.Location = new System.Drawing.Point(0, 46);
            this.Box1.Margin = new System.Windows.Forms.Padding(2);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(765, 351);
            this.Box1.TabIndex = 0;
            // 
            // GUI_yn
            // 
            this.GUI_yn.AllowDrop = true;
            this.GUI_yn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GUI_yn.DisplayMember = "No";
            this.GUI_yn.DropDownHeight = 100;
            this.GUI_yn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GUI_yn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GUI_yn.Font = new System.Drawing.Font("阿里巴巴普惠体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GUI_yn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GUI_yn.IntegralHeight = false;
            this.GUI_yn.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.GUI_yn.Location = new System.Drawing.Point(567, 143);
            this.GUI_yn.Name = "GUI_yn";
            this.GUI_yn.Size = new System.Drawing.Size(110, 28);
            this.GUI_yn.Sorted = true;
            this.GUI_yn.TabIndex = 10;
            // 
            // T_GUI_yn
            // 
            this.T_GUI_yn.AutoSize = true;
            this.T_GUI_yn.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T_GUI_yn.Location = new System.Drawing.Point(549, 118);
            this.T_GUI_yn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.T_GUI_yn.Name = "T_GUI_yn";
            this.T_GUI_yn.Size = new System.Drawing.Size(132, 22);
            this.T_GUI_yn.TabIndex = 9;
            this.T_GUI_yn.Text = "是否显示原版GUI";
            // 
            // Max_v
            // 
            this.Max_v.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Max_v.Location = new System.Drawing.Point(637, 78);
            this.Max_v.Margin = new System.Windows.Forms.Padding(2);
            this.Max_v.Name = "Max_v";
            this.Max_v.Size = new System.Drawing.Size(118, 29);
            this.Max_v.TabIndex = 8;
            this.Max_v.Text = "1G";
            // 
            // T_Max_v
            // 
            this.T_Max_v.AutoSize = true;
            this.T_Max_v.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T_Max_v.Location = new System.Drawing.Point(665, 54);
            this.T_Max_v.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.T_Max_v.Name = "T_Max_v";
            this.T_Max_v.Size = new System.Drawing.Size(74, 22);
            this.T_Max_v.TabIndex = 7;
            this.T_Max_v.Text = "最大内存";
            // 
            // Server_Name
            // 
            this.Server_Name.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Server_Name.Location = new System.Drawing.Point(502, 78);
            this.Server_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Server_Name.Name = "Server_Name";
            this.Server_Name.Size = new System.Drawing.Size(106, 29);
            this.Server_Name.TabIndex = 6;
            // 
            // T_Server_Name
            // 
            this.T_Server_Name.AutoSize = true;
            this.T_Server_Name.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T_Server_Name.Location = new System.Drawing.Point(513, 54);
            this.T_Server_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.T_Server_Name.Name = "T_Server_Name";
            this.T_Server_Name.Size = new System.Drawing.Size(90, 22);
            this.T_Server_Name.TabIndex = 5;
            this.T_Server_Name.Text = "服务端名称";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("阿里巴巴普惠体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(492, 276);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(262, 52);
            this.Start.TabIndex = 4;
            this.Start.Text = "开启";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Server_Ver
            // 
            this.Server_Ver.AllowDrop = true;
            this.Server_Ver.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Server_Ver.DropDownHeight = 100;
            this.Server_Ver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Server_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Server_Ver.Font = new System.Drawing.Font("阿里巴巴普惠体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Server_Ver.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Server_Ver.IntegralHeight = false;
            this.Server_Ver.Items.AddRange(new object[] {
            "1.10",
            "1.10.1",
            "1.10.2",
            "1.11",
            "1.11.1",
            "1.11.2",
            "1.12",
            "1.12.1",
            "1.12.2",
            "1.13",
            "1.13.1",
            "1.13.2",
            "1.14",
            "1.14.1",
            "1.14.2",
            "1.14.3",
            "1.14.4",
            "1.15",
            "1.15.1",
            "1.15.2",
            "1.16",
            "1.16.1",
            "1.16.2",
            "1.16.3",
            "1.16.4",
            "1.16.5",
            "1.7.10",
            "1.8",
            "1.8.1",
            "1.8.2",
            "1.8.3",
            "1.8.4",
            "1.8.5",
            "1.8.6",
            "1.8.7",
            "1.8.8",
            "1.8.9",
            "1.9.0",
            "1.9.1",
            "1.9.2",
            "1.9.3",
            "1.9.4"});
            this.Server_Ver.Location = new System.Drawing.Point(18, 83);
            this.Server_Ver.Name = "Server_Ver";
            this.Server_Ver.Size = new System.Drawing.Size(110, 28);
            this.Server_Ver.Sorted = true;
            this.Server_Ver.TabIndex = 3;
            this.Server_Ver.SelectedIndexChanged += new System.EventHandler(this.Server_Ver_SelectedIndexChanged);
            // 
            // B_Download
            // 
            this.B_Download.BackColor = System.Drawing.SystemColors.HotTrack;
            this.B_Download.FlatAppearance.BorderSize = 0;
            this.B_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Download.Font = new System.Drawing.Font("阿里巴巴普惠体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Download.ForeColor = System.Drawing.Color.White;
            this.B_Download.Location = new System.Drawing.Point(11, 276);
            this.B_Download.Margin = new System.Windows.Forms.Padding(2);
            this.B_Download.Name = "B_Download";
            this.B_Download.Size = new System.Drawing.Size(262, 52);
            this.B_Download.TabIndex = 2;
            this.B_Download.Text = "下载";
            this.B_Download.UseVisualStyleBackColor = false;
            this.B_Download.Click += new System.EventHandler(this.Download_Button_Click);
            // 
            // A_Server_Ver
            // 
            this.A_Server_Ver.AutoSize = true;
            this.A_Server_Ver.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A_Server_Ver.Location = new System.Drawing.Point(14, 48);
            this.A_Server_Ver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A_Server_Ver.Name = "A_Server_Ver";
            this.A_Server_Ver.Size = new System.Drawing.Size(90, 22);
            this.A_Server_Ver.TabIndex = 1;
            this.A_Server_Ver.Text = "服务端版本";
            // 
            // logs
            // 
            this.logs.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logs.Location = new System.Drawing.Point(120, 401);
            this.logs.Margin = new System.Windows.Forms.Padding(2);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(538, 29);
            this.logs.TabIndex = 1;
            this.logs.Text = "输出";
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Color1.Controls.Add(this.T_FormNmae);
            this.Color1.Controls.Add(this.Mini);
            this.Color1.Controls.Add(this.Close);
            this.Color1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Color1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Color1.Location = new System.Drawing.Point(0, 0);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(765, 50);
            this.Color1.TabIndex = 5;
            this.Color1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Color1_MouseDown);
            // 
            // T_FormNmae
            // 
            this.T_FormNmae.AutoSize = true;
            this.T_FormNmae.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.T_FormNmae.Font = new System.Drawing.Font("阿里巴巴普惠体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T_FormNmae.ForeColor = System.Drawing.Color.White;
            this.T_FormNmae.Location = new System.Drawing.Point(13, 12);
            this.T_FormNmae.Name = "T_FormNmae";
            this.T_FormNmae.Size = new System.Drawing.Size(166, 27);
            this.T_FormNmae.TabIndex = 5;
            this.T_FormNmae.Text = "Minecraft 开服器";
            // 
            // Mini
            // 
            this.Mini.FlatAppearance.BorderSize = 0;
            this.Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mini.Image = global::Minecraft_开服器.Properties.Resources.mini;
            this.Mini.Location = new System.Drawing.Point(685, 8);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(31, 33);
            this.Mini.TabIndex = 4;
            this.Mini.UseVisualStyleBackColor = true;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = global::Minecraft_开服器.Properties.Resources.close1;
            this.Close.Location = new System.Drawing.Point(722, 7);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 34);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // O_Server_Path1
            // 
            this.O_Server_Path1.FileName = "openFileDialog1";
            // 
            // T_ServerPath2
            // 
            this.T_ServerPath2.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T_ServerPath2.Location = new System.Drawing.Point(492, 243);
            this.T_ServerPath2.Margin = new System.Windows.Forms.Padding(2);
            this.T_ServerPath2.Name = "T_ServerPath2";
            this.T_ServerPath2.Size = new System.Drawing.Size(116, 29);
            this.T_ServerPath2.TabIndex = 11;
            this.T_ServerPath2.Visible = false;
            // 
            // T_ServerNP
            // 
            this.T_ServerNP.Font = new System.Drawing.Font("阿里巴巴普惠体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T_ServerNP.Location = new System.Drawing.Point(629, 243);
            this.T_ServerNP.Margin = new System.Windows.Forms.Padding(2);
            this.T_ServerNP.Name = "T_ServerNP";
            this.T_ServerNP.Size = new System.Drawing.Size(125, 29);
            this.T_ServerNP.TabIndex = 12;
            this.T_ServerNP.Visible = false;
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 440);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.Box1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Download";
            this.Text = "下载";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Download_Closing);
            this.Load += new System.EventHandler(this.Download_Load);
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.Color1.ResumeLayout(false);
            this.Color1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Box1;
        private System.Windows.Forms.Button B_Download;
        private System.Windows.Forms.Label A_Server_Ver;
        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.FolderBrowserDialog R_Server_Path1;
        private System.Windows.Forms.Panel Color1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.Label T_FormNmae;
        private System.Windows.Forms.ComboBox Server_Ver;
        private System.Windows.Forms.TextBox Server_Name;
        private System.Windows.Forms.Label T_Server_Name;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ComboBox GUI_yn;
        private System.Windows.Forms.Label T_GUI_yn;
        private System.Windows.Forms.TextBox Max_v;
        private System.Windows.Forms.Label T_Max_v;
        private System.Windows.Forms.FolderBrowserDialog R_Server_Path2;
        private System.Windows.Forms.OpenFileDialog O_Server_Path1;
        private System.Windows.Forms.TextBox T_ServerNP;
        private System.Windows.Forms.TextBox T_ServerPath2;
    }
}

