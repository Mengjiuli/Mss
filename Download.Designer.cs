
namespace Minecraft_开服器
{
    partial class Wds_Download
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
            this.Btn_Download = new System.Windows.Forms.Button();
            this.TextBox_ServerVer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Download
            // 
            this.Btn_Download.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Download.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Download.Font = new System.Drawing.Font("阿里巴巴普惠体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Download.ForeColor = System.Drawing.Color.White;
            this.Btn_Download.Location = new System.Drawing.Point(745, 436);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(193, 52);
            this.Btn_Download.TabIndex = 0;
            this.Btn_Download.Text = "下载";
            this.Btn_Download.UseVisualStyleBackColor = false;
            // 
            // TextBox_ServerVer
            // 
            this.TextBox_ServerVer.Location = new System.Drawing.Point(347, 151);
            this.TextBox_ServerVer.Name = "TextBox_ServerVer";
            this.TextBox_ServerVer.Size = new System.Drawing.Size(174, 21);
            this.TextBox_ServerVer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体", 14F);
            this.label1.Location = new System.Drawing.Point(383, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务端版本";
            // 
            // Btn_About
            // 
            this.Btn_About.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_About.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_About.Font = new System.Drawing.Font("阿里巴巴普惠体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_About.ForeColor = System.Drawing.Color.White;
            this.Btn_About.Location = new System.Drawing.Point(12, 436);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(129, 52);
            this.Btn_About.TabIndex = 3;
            this.Btn_About.Text = "关于本页";
            this.Btn_About.UseVisualStyleBackColor = false;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // Wds_Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.Btn_About);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_ServerVer);
            this.Controls.Add(this.Btn_Download);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wds_Download";
            this.Text = "Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Download;
        private System.Windows.Forms.TextBox TextBox_ServerVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_About;
    }
}