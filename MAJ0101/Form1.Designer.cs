namespace MAJ0101
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
            this.administraciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dochadzkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadaniePraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pridanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spravaDomenyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamestnanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pridanieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mojProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupHardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciaToolStripMenuItem,
            this.zadaniePraceToolStripMenuItem,
            this.spravaDomenyToolStripMenuItem,
            this.mojProfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciaToolStripMenuItem
            // 
            this.administraciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravaToolStripMenuItem,
            this.dochadzkaToolStripMenuItem});
            this.administraciaToolStripMenuItem.Name = "administraciaToolStripMenuItem";
            this.administraciaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.administraciaToolStripMenuItem.Text = "Prehlad pracovisk";
            // 
            // upravaToolStripMenuItem
            // 
            this.upravaToolStripMenuItem.Name = "upravaToolStripMenuItem";
            this.upravaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.upravaToolStripMenuItem.Text = "Aktualny stav";
            this.upravaToolStripMenuItem.Click += new System.EventHandler(this.upravaToolStripMenuItem_Click);
            // 
            // dochadzkaToolStripMenuItem
            // 
            this.dochadzkaToolStripMenuItem.Name = "dochadzkaToolStripMenuItem";
            this.dochadzkaToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.dochadzkaToolStripMenuItem.Text = "Dochadzka";
            this.dochadzkaToolStripMenuItem.Click += new System.EventHandler(this.dochadzkaToolStripMenuItem_Click);
            // 
            // zadaniePraceToolStripMenuItem
            // 
            this.zadaniePraceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pridanieToolStripMenuItem});
            this.zadaniePraceToolStripMenuItem.Name = "zadaniePraceToolStripMenuItem";
            this.zadaniePraceToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.zadaniePraceToolStripMenuItem.Text = "Zadanie prace";
            // 
            // pridanieToolStripMenuItem
            // 
            this.pridanieToolStripMenuItem.Name = "pridanieToolStripMenuItem";
            this.pridanieToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.pridanieToolStripMenuItem.Text = "Pridanie";
            this.pridanieToolStripMenuItem.Click += new System.EventHandler(this.pridanieToolStripMenuItem_Click);
            // 
            // spravaDomenyToolStripMenuItem
            // 
            this.spravaDomenyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamestnanciToolStripMenuItem,
            this.backupHardwareToolStripMenuItem});
            this.spravaDomenyToolStripMenuItem.Name = "spravaDomenyToolStripMenuItem";
            this.spravaDomenyToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.spravaDomenyToolStripMenuItem.Text = "Sprava domeny";
            // 
            // zamestnanciToolStripMenuItem
            // 
            this.zamestnanciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravaToolStripMenuItem2,
            this.pridanieToolStripMenuItem1});
            this.zamestnanciToolStripMenuItem.Name = "zamestnanciToolStripMenuItem";
            this.zamestnanciToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.zamestnanciToolStripMenuItem.Text = "Zamestnanci";
            // 
            // upravaToolStripMenuItem2
            // 
            this.upravaToolStripMenuItem2.Name = "upravaToolStripMenuItem2";
            this.upravaToolStripMenuItem2.Size = new System.Drawing.Size(138, 26);
            this.upravaToolStripMenuItem2.Text = "Uprava";
            this.upravaToolStripMenuItem2.Click += new System.EventHandler(this.upravaToolStripMenuItem2_Click);
            // 
            // pridanieToolStripMenuItem1
            // 
            this.pridanieToolStripMenuItem1.Name = "pridanieToolStripMenuItem1";
            this.pridanieToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
            this.pridanieToolStripMenuItem1.Text = "Pridanie";
            this.pridanieToolStripMenuItem1.Click += new System.EventHandler(this.pridanieToolStripMenuItem1_Click);
            // 
            // mojProfilToolStripMenuItem
            // 
            this.mojProfilToolStripMenuItem.Name = "mojProfilToolStripMenuItem";
            this.mojProfilToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.mojProfilToolStripMenuItem.Text = "Moj profil";
            // 
            // backupHardwareToolStripMenuItem
            // 
            this.backupHardwareToolStripMenuItem.Name = "backupHardwareToolStripMenuItem";
            this.backupHardwareToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.backupHardwareToolStripMenuItem.Text = "Backup Hardware";
            this.backupHardwareToolStripMenuItem.Click += new System.EventHandler(this.backupHardwareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 593);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadaniePraceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spravaDomenyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dochadzkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pridanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamestnanciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pridanieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backupHardwareToolStripMenuItem;
    }
}

