namespace MAJ0101.Forms
{
    partial class FormAktualny_stav
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
            this.zobrazit = new System.Windows.Forms.Button();
            this.upravit = new System.Windows.Forms.Button();
            this.vytvorit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pracoviskoCombo = new System.Windows.Forms.ComboBox();
            this.gridAktivita = new System.Windows.Forms.DataGridView();
            this.Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.Label();
            this.Pracovisko = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAktivita)).BeginInit();
            this.SuspendLayout();
            // 
            // zobrazit
            // 
            this.zobrazit.Location = new System.Drawing.Point(340, 44);
            this.zobrazit.Name = "zobrazit";
            this.zobrazit.Size = new System.Drawing.Size(75, 36);
            this.zobrazit.TabIndex = 0;
            this.zobrazit.Text = "Zobrazit";
            this.zobrazit.UseVisualStyleBackColor = true;
            this.zobrazit.Click += new System.EventHandler(this.button1_Click);
            // 
            // upravit
            // 
            this.upravit.Location = new System.Drawing.Point(33, 485);
            this.upravit.Name = "upravit";
            this.upravit.Size = new System.Drawing.Size(83, 43);
            this.upravit.TabIndex = 1;
            this.upravit.Text = "Upravit zamestnanca";
            this.upravit.UseVisualStyleBackColor = true;
            this.upravit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // vytvorit
            // 
            this.vytvorit.Location = new System.Drawing.Point(215, 485);
            this.vytvorit.Name = "vytvorit";
            this.vytvorit.Size = new System.Drawing.Size(100, 43);
            this.vytvorit.TabIndex = 2;
            this.vytvorit.Text = "Vytvorit zamestnanca";
            this.vytvorit.UseVisualStyleBackColor = true;
            this.vytvorit.Click += new System.EventHandler(this.vytvorit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Pridanie projektku";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Nahlasenie chyby";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pracoviskoCombo
            // 
            this.pracoviskoCombo.FormattingEnabled = true;
            this.pracoviskoCombo.Location = new System.Drawing.Point(123, 47);
            this.pracoviskoCombo.Name = "pracoviskoCombo";
            this.pracoviskoCombo.Size = new System.Drawing.Size(211, 24);
            this.pracoviskoCombo.TabIndex = 5;
            this.pracoviskoCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gridAktivita
            // 
            this.gridAktivita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAktivita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Meno,
            this.Priezvisko,
            this.Status});
            this.gridAktivita.Location = new System.Drawing.Point(43, 110);
            this.gridAktivita.Name = "gridAktivita";
            this.gridAktivita.ReadOnly = true;
            this.gridAktivita.RowTemplate.Height = 24;
            this.gridAktivita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAktivita.Size = new System.Drawing.Size(470, 358);
            this.gridAktivita.TabIndex = 6;
            this.gridAktivita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAktivita_CellDoubleClick);
            this.gridAktivita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAktivita_CellContentClick);
            this.gridAktivita.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAktivita_CellDoubleClick);
            this.gridAktivita.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridAktivita_CellMouseDoubleClick);
            // 
            // Meno
            // 
            this.Meno.DataPropertyName = "Name";
            this.Meno.HeaderText = "Meno";
            this.Meno.Name = "Meno";
            this.Meno.ReadOnly = true;
            // 
            // Priezvisko
            // 
            this.Priezvisko.DataPropertyName = "Surname";
            this.Priezvisko.HeaderText = "Priezvisko";
            this.Priezvisko.Name = "Priezvisko";
            this.Priezvisko.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "State";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(520, 110);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(46, 17);
            this.info.TabIndex = 7;
            this.info.Text = "label1";
            // 
            // Pracovisko
            // 
            this.Pracovisko.AutoSize = true;
            this.Pracovisko.Location = new System.Drawing.Point(40, 54);
            this.Pracovisko.Name = "Pracovisko";
            this.Pracovisko.Size = new System.Drawing.Size(77, 17);
            this.Pracovisko.TabIndex = 8;
            this.Pracovisko.Text = "Pracovisko";
            // 
            // FormAktualny_stav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.Controls.Add(this.Pracovisko);
            this.Controls.Add(this.info);
            this.Controls.Add(this.gridAktivita);
            this.Controls.Add(this.pracoviskoCombo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.vytvorit);
            this.Controls.Add(this.upravit);
            this.Controls.Add(this.zobrazit);
            this.Name = "FormAktualny_stav";
            this.Text = "FormAktualny_stav";
            this.Load += new System.EventHandler(this.FormAktualny_stav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAktivita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zobrazit;
        private System.Windows.Forms.Button upravit;
        private System.Windows.Forms.Button vytvorit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox pracoviskoCombo;
        private System.Windows.Forms.DataGridView gridAktivita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label Pracovisko;
    }
}