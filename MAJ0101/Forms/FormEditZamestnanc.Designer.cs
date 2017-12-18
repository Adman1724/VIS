namespace MAJ0101.Forms
{
    partial class FormEditZamestnanc
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
            this.tmeno = new System.Windows.Forms.TextBox();
            this.tpriezvisko = new System.Windows.Forms.TextBox();
            this.tadresa = new System.Windows.Forms.TextBox();
            this.trodnecislo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.meno = new System.Windows.Forms.Label();
            this.priezvisko = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.Label();
            this.rodne_cislo = new System.Windows.Forms.Label();
            this.tpohlavie = new System.Windows.Forms.TextBox();
            this.pohlavie = new System.Windows.Forms.Label();
            this.projekt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tmeno
            // 
            this.tmeno.Location = new System.Drawing.Point(182, 63);
            this.tmeno.Name = "tmeno";
            this.tmeno.Size = new System.Drawing.Size(148, 22);
            this.tmeno.TabIndex = 0;
            // 
            // tpriezvisko
            // 
            this.tpriezvisko.Location = new System.Drawing.Point(182, 114);
            this.tpriezvisko.Name = "tpriezvisko";
            this.tpriezvisko.Size = new System.Drawing.Size(148, 22);
            this.tpriezvisko.TabIndex = 1;
            // 
            // tadresa
            // 
            this.tadresa.Location = new System.Drawing.Point(182, 158);
            this.tadresa.Name = "tadresa";
            this.tadresa.Size = new System.Drawing.Size(148, 22);
            this.tadresa.TabIndex = 2;
            // 
            // trodnecislo
            // 
            this.trodnecislo.Location = new System.Drawing.Point(182, 210);
            this.trodnecislo.Name = "trodnecislo";
            this.trodnecislo.Size = new System.Drawing.Size(148, 22);
            this.trodnecislo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pridelenie Projektu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(85, 68);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(43, 17);
            this.meno.TabIndex = 7;
            this.meno.Text = "Meno";
            // 
            // priezvisko
            // 
            this.priezvisko.AutoSize = true;
            this.priezvisko.Location = new System.Drawing.Point(85, 119);
            this.priezvisko.Name = "priezvisko";
            this.priezvisko.Size = new System.Drawing.Size(72, 17);
            this.priezvisko.TabIndex = 8;
            this.priezvisko.Text = "Priezvisko";
            // 
            // adresa
            // 
            this.adresa.AutoSize = true;
            this.adresa.Location = new System.Drawing.Point(85, 163);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(53, 17);
            this.adresa.TabIndex = 9;
            this.adresa.Text = "Adresa";
            // 
            // rodne_cislo
            // 
            this.rodne_cislo.AutoSize = true;
            this.rodne_cislo.Location = new System.Drawing.Point(85, 215);
            this.rodne_cislo.Name = "rodne_cislo";
            this.rodne_cislo.Size = new System.Drawing.Size(82, 17);
            this.rodne_cislo.TabIndex = 10;
            this.rodne_cislo.Text = "Rodne cislo";
            // 
            // tpohlavie
            // 
            this.tpohlavie.Location = new System.Drawing.Point(182, 267);
            this.tpohlavie.Name = "tpohlavie";
            this.tpohlavie.Size = new System.Drawing.Size(148, 22);
            this.tpohlavie.TabIndex = 11;
            // 
            // pohlavie
            // 
            this.pohlavie.AutoSize = true;
            this.pohlavie.Location = new System.Drawing.Point(85, 272);
            this.pohlavie.Name = "pohlavie";
            this.pohlavie.Size = new System.Drawing.Size(62, 17);
            this.pohlavie.TabIndex = 13;
            this.pohlavie.Text = "Pohlavie";
            // 
            // projekt
            // 
            this.projekt.AutoSize = true;
            this.projekt.Location = new System.Drawing.Point(85, 325);
            this.projekt.Name = "projekt";
            this.projekt.Size = new System.Drawing.Size(59, 17);
            this.projekt.TabIndex = 16;
            this.projekt.Text = "Projekty";
            this.projekt.Click += new System.EventHandler(this.projekt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Heslo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "vypis";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 378);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 22);
            this.textBox3.TabIndex = 21;
            // 
            // FormEditZamestnanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 666);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.projekt);
            this.Controls.Add(this.pohlavie);
            this.Controls.Add(this.tpohlavie);
            this.Controls.Add(this.rodne_cislo);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.priezvisko);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trodnecislo);
            this.Controls.Add(this.tadresa);
            this.Controls.Add(this.tpriezvisko);
            this.Controls.Add(this.tmeno);
            this.Name = "FormEditZamestnanc";
            this.Text = "FormUpravaZamestnanca";
            this.Load += new System.EventHandler(this.FormUpravaZamestnanca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tmeno;
        private System.Windows.Forms.TextBox tpriezvisko;
        private System.Windows.Forms.TextBox tadresa;
        private System.Windows.Forms.TextBox trodnecislo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label priezvisko;
        private System.Windows.Forms.Label adresa;
        private System.Windows.Forms.Label rodne_cislo;
        private System.Windows.Forms.TextBox tpohlavie;
        private System.Windows.Forms.Label pohlavie;
        private System.Windows.Forms.Label projekt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}