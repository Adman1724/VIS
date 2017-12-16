namespace MAJ0101.Forms
{
    partial class FormCreateProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textZaciatok = new System.Windows.Forms.Label();
            this.zaciatok = new System.Windows.Forms.MonthCalendar();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboZamestanec = new System.Windows.Forms.ComboBox();
            this.textKoniec = new System.Windows.Forms.Label();
            this.koniec = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Riaditel projetu";
            // 
            // textZaciatok
            // 
            this.textZaciatok.AutoSize = true;
            this.textZaciatok.Location = new System.Drawing.Point(105, 144);
            this.textZaciatok.Name = "textZaciatok";
            this.textZaciatok.Size = new System.Drawing.Size(117, 17);
            this.textZaciatok.TabIndex = 2;
            this.textZaciatok.Text = "Zaciatok projektu";
            // 
            // zaciatok
            // 
            this.zaciatok.Location = new System.Drawing.Point(6, 190);
            this.zaciatok.Name = "zaciatok";
            this.zaciatok.TabIndex = 3;
            this.zaciatok.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.zaciatok_DateChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(133, 43);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 22);
            this.textName.TabIndex = 4;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // comboZamestanec
            // 
            this.comboZamestanec.FormattingEnabled = true;
            this.comboZamestanec.Location = new System.Drawing.Point(133, 97);
            this.comboZamestanec.Name = "comboZamestanec";
            this.comboZamestanec.Size = new System.Drawing.Size(121, 24);
            this.comboZamestanec.TabIndex = 5;
            // 
            // textKoniec
            // 
            this.textKoniec.AutoSize = true;
            this.textKoniec.Location = new System.Drawing.Point(396, 144);
            this.textKoniec.Name = "textKoniec";
            this.textKoniec.Size = new System.Drawing.Size(106, 17);
            this.textKoniec.TabIndex = 6;
            this.textKoniec.Text = "Koniec projektu";
            // 
            // koniec
            // 
            this.koniec.Location = new System.Drawing.Point(309, 190);
            this.koniec.Name = "koniec";
            this.koniec.TabIndex = 7;
            this.koniec.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.koniec_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Vytvorit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.textKoniec);
            this.Controls.Add(this.comboZamestanec);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.zaciatok);
            this.Controls.Add(this.textZaciatok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateProject";
            this.Text = "FormCreateProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textZaciatok;
        private System.Windows.Forms.MonthCalendar zaciatok;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboZamestanec;
        private System.Windows.Forms.Label textKoniec;
        private System.Windows.Forms.MonthCalendar koniec;
        private System.Windows.Forms.Button button1;
    }
}