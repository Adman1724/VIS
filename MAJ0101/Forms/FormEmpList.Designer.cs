namespace MAJ0101.Forms
{
    partial class FormEmpList
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
            this.gridZamestnanec = new System.Windows.Forms.DataGridView();
            this.Meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodne_cislo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pohlavie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridZamestnanec)).BeginInit();
            this.SuspendLayout();
            // 
            // gridZamestnanec
            // 
            this.gridZamestnanec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridZamestnanec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Meno,
            this.Priezvisko,
            this.rodne_cislo,
            this.Adresa,
            this.Pohlavie});
            this.gridZamestnanec.Location = new System.Drawing.Point(2, 2);
            this.gridZamestnanec.Name = "gridZamestnanec";
            this.gridZamestnanec.RowTemplate.Height = 24;
            this.gridZamestnanec.Size = new System.Drawing.Size(821, 472);
            this.gridZamestnanec.TabIndex = 0;
            this.gridZamestnanec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridZamestnanec.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridZamestnanec_CellMouseClick);
            // 
            // Meno
            // 
            this.Meno.DataPropertyName = "Name";
            this.Meno.HeaderText = "Meno";
            this.Meno.Name = "Meno";
            // 
            // Priezvisko
            // 
            this.Priezvisko.DataPropertyName = "LastName";
            this.Priezvisko.HeaderText = "Priezvisko";
            this.Priezvisko.Name = "Priezvisko";
            // 
            // rodne_cislo
            // 
            this.rodne_cislo.DataPropertyName = "PerIdNum";
            this.rodne_cislo.HeaderText = "Rodne cislo";
            this.rodne_cislo.Name = "rodne_cislo";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adress";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // Pohlavie
            // 
            this.Pohlavie.DataPropertyName = "Sex";
            this.Pohlavie.HeaderText = "Pohlavie";
            this.Pohlavie.Name = "Pohlavie";
            // 
            // FormEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 469);
            this.Controls.Add(this.gridZamestnanec);
            this.Name = "FormEmpList";
            this.Text = "FormEmpList";
            ((System.ComponentModel.ISupportInitialize)(this.gridZamestnanec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridZamestnanec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priezvisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodne_cislo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pohlavie;
    }
}