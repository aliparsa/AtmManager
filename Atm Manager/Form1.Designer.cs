namespace Atm_Manager
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.مدیریتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کالاهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کارگزارانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // مدیریتToolStripMenuItem
            // 
            this.مدیریتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کالاهاToolStripMenuItem,
            this.کارگزارانToolStripMenuItem});
            this.مدیریتToolStripMenuItem.Name = "مدیریتToolStripMenuItem";
            this.مدیریتToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.مدیریتToolStripMenuItem.Text = "مدیریت";
            this.مدیریتToolStripMenuItem.Click += new System.EventHandler(this.مدیریتToolStripMenuItem_Click);
            // 
            // کالاهاToolStripMenuItem
            // 
            this.کالاهاToolStripMenuItem.Name = "کالاهاToolStripMenuItem";
            this.کالاهاToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.کالاهاToolStripMenuItem.Text = "کالاها";
            this.کالاهاToolStripMenuItem.Click += new System.EventHandler(this.کالاهاToolStripMenuItem_Click_1);
            // 
            // کارگزارانToolStripMenuItem
            // 
            this.کارگزارانToolStripMenuItem.Name = "کارگزارانToolStripMenuItem";
            this.کارگزارانToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.کارگزارانToolStripMenuItem.Text = "کارگزاران";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 434);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مدیریتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کالاهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کارگزارانToolStripMenuItem;
    }
}

