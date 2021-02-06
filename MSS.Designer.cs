
namespace Minecraft_开服器
{
    partial class Windows_Mss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Windows_Mss));
            this.R_Server_Path1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Color1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.A_FormNmae = new System.Windows.Forms.Label();
            this.R_Server_Path2 = new System.Windows.Forms.FolderBrowserDialog();
            this.O_Server_Path1 = new System.Windows.Forms.OpenFileDialog();
            this.Box = new System.Windows.Forms.Panel();
            this.Button_Info = new System.Windows.Forms.Button();
            this.Button_Download = new System.Windows.Forms.Button();
            this.Button_Home = new System.Windows.Forms.Button();
            this.Mini = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Color1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Color1
            // 
            this.Color1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Color1.Controls.Add(this.Button_Info);
            this.Color1.Controls.Add(this.Button_Download);
            this.Color1.Controls.Add(this.Button_Home);
            this.Color1.Controls.Add(this.panel1);
            this.Color1.Controls.Add(this.A_FormNmae);
            this.Color1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Color1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Color1.Location = new System.Drawing.Point(0, 0);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(950, 55);
            this.Color1.TabIndex = 5;
            this.Color1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Color1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Mini);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(869, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 55);
            this.panel1.TabIndex = 6;
            // 
            // A_FormNmae
            // 
            this.A_FormNmae.AutoSize = true;
            this.A_FormNmae.BackColor = System.Drawing.SystemColors.Highlight;
            this.A_FormNmae.Font = new System.Drawing.Font("阿里巴巴普惠体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A_FormNmae.ForeColor = System.Drawing.Color.White;
            this.A_FormNmae.Location = new System.Drawing.Point(12, 12);
            this.A_FormNmae.Name = "A_FormNmae";
            this.A_FormNmae.Size = new System.Drawing.Size(166, 27);
            this.A_FormNmae.TabIndex = 5;
            this.A_FormNmae.Text = "Minecraft 开服器";
            // 
            // O_Server_Path1
            // 
            this.O_Server_Path1.FileName = "openFileDialog1";
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.Box.Location = new System.Drawing.Point(0, 55);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(950, 500);
            this.Box.TabIndex = 14;
            // 
            // Button_Info
            // 
            this.Button_Info.FlatAppearance.BorderSize = 0;
            this.Button_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Info.Font = new System.Drawing.Font("阿里巴巴普惠体", 14F);
            this.Button_Info.ForeColor = System.Drawing.Color.White;
            this.Button_Info.Image = ((System.Drawing.Image)(resources.GetObject("Button_Info.Image")));
            this.Button_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Info.Location = new System.Drawing.Point(518, 10);
            this.Button_Info.Name = "Button_Info";
            this.Button_Info.Size = new System.Drawing.Size(85, 33);
            this.Button_Info.TabIndex = 8;
            this.Button_Info.Text = "关于";
            this.Button_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Info.UseVisualStyleBackColor = true;
            this.Button_Info.Click += new System.EventHandler(this.Button_Info_Click);
            // 
            // Button_Download
            // 
            this.Button_Download.FlatAppearance.BorderSize = 0;
            this.Button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Download.Font = new System.Drawing.Font("阿里巴巴普惠体", 14F);
            this.Button_Download.ForeColor = System.Drawing.Color.White;
            this.Button_Download.Image = ((System.Drawing.Image)(resources.GetObject("Button_Download.Image")));
            this.Button_Download.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Download.Location = new System.Drawing.Point(422, 10);
            this.Button_Download.Name = "Button_Download";
            this.Button_Download.Size = new System.Drawing.Size(85, 33);
            this.Button_Download.TabIndex = 7;
            this.Button_Download.Text = "下载";
            this.Button_Download.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Download.UseVisualStyleBackColor = true;
            this.Button_Download.Click += new System.EventHandler(this.Button_Download_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.Font = new System.Drawing.Font("阿里巴巴普惠体", 14F);
            this.Button_Home.ForeColor = System.Drawing.Color.White;
            this.Button_Home.Image = ((System.Drawing.Image)(resources.GetObject("Button_Home.Image")));
            this.Button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.Location = new System.Drawing.Point(331, 10);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(85, 33);
            this.Button_Home.TabIndex = 5;
            this.Button_Home.Text = "主页";
            this.Button_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Home.UseVisualStyleBackColor = true;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // Mini
            // 
            this.Mini.FlatAppearance.BorderSize = 0;
            this.Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mini.Image = ((System.Drawing.Image)(resources.GetObject("Mini.Image")));
            this.Mini.Location = new System.Drawing.Point(3, 13);
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
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(39, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 34);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Windows_Mss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 555);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Color1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Windows_Mss";
            this.Text = "下载";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Download_Closing);
            this.Load += new System.EventHandler(this.Download_Load);
            this.Color1.ResumeLayout(false);
            this.Color1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog R_Server_Path1;
        private System.Windows.Forms.Panel Color1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.Label A_FormNmae;
        private System.Windows.Forms.FolderBrowserDialog R_Server_Path2;
        private System.Windows.Forms.OpenFileDialog O_Server_Path1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Box;
        private System.Windows.Forms.Button Button_Home;
        private System.Windows.Forms.Button Button_Info;
        private System.Windows.Forms.Button Button_Download;
    }
}

