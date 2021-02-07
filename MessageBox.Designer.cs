
namespace Minecraft_开服器
{
    partial class Wds_MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wds_MessageBox));
            this.Box1 = new System.Windows.Forms.Panel();
            this.A_Title = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Box2 = new System.Windows.Forms.Panel();
            this.Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Box1.Controls.Add(this.A_Title);
            this.Box1.Controls.Add(this.Close);
            resources.ApplyResources(this.Box1, "Box1");
            this.Box1.Name = "Box1";
            // 
            // A_Title
            // 
            resources.ApplyResources(this.A_Title, "A_Title");
            this.A_Title.ForeColor = System.Drawing.Color.White;
            this.A_Title.Name = "A_Title";
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Close, "Close");
            this.Close.Name = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Box2, "Box2");
            this.Box2.Name = "Box2";
            // 
            // Wds_MessageBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wds_MessageBox";
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Box1;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label A_Title;
        private System.Windows.Forms.Panel Box2;
    }
}