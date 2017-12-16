namespace MAJ0101.Forms
{
    partial class FormAttendance
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
            this.comboWork = new System.Windows.Forms.ComboBox();
            this.comboZam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridStep = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.zaciatokD = new System.Windows.Forms.DateTimePicker();
            this.koniecD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStep)).BeginInit();
            this.SuspendLayout();
            // 
            // comboWork
            // 
            this.comboWork.FormattingEnabled = true;
            this.comboWork.Location = new System.Drawing.Point(147, 40);
            this.comboWork.Name = "comboWork";
            this.comboWork.Size = new System.Drawing.Size(147, 24);
            this.comboWork.TabIndex = 0;
            this.comboWork.SelectedIndexChanged += new System.EventHandler(this.comboWork_SelectedIndexChanged);
            // 
            // comboZam
            // 
            this.comboZam.FormattingEnabled = true;
            this.comboZam.Location = new System.Drawing.Point(425, 40);
            this.comboZam.Name = "comboZam";
            this.comboZam.Size = new System.Drawing.Size(143, 24);
            this.comboZam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pracovisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zamestnanec";
            // 
            // gridStep
            // 
            this.gridStep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Status});
            this.gridStep.Location = new System.Drawing.Point(223, 94);
            this.gridStep.Name = "gridStep";
            this.gridStep.RowTemplate.Height = 24;
            this.gridStep.Size = new System.Drawing.Size(373, 379);
            this.gridStep.TabIndex = 4;
            this.gridStep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStep_CellContentClick);
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Date";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zaciatokD
            // 
            this.zaciatokD.Location = new System.Drawing.Point(12, 117);
            this.zaciatokD.Name = "zaciatokD";
            this.zaciatokD.Size = new System.Drawing.Size(200, 22);
            this.zaciatokD.TabIndex = 6;
            this.zaciatokD.ValueChanged += new System.EventHandler(this.zaciatokD_ValueChanged);
            // 
            // koniecD
            // 
            this.koniecD.Location = new System.Drawing.Point(12, 191);
            this.koniecD.Name = "koniecD";
            this.koniecD.Size = new System.Drawing.Size(200, 22);
            this.koniecD.TabIndex = 7;
            this.koniecD.ValueChanged += new System.EventHandler(this.koniecD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zaciatok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Koniec";
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.koniecD);
            this.Controls.Add(this.zaciatokD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridStep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboZam);
            this.Controls.Add(this.comboWork);
            this.Name = "FormAttendance";
            this.Text = "FormAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.gridStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWork;
        private System.Windows.Forms.ComboBox comboZam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridStep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker zaciatokD;
        private System.Windows.Forms.DateTimePicker koniecD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}