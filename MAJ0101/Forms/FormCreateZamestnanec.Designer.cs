namespace MAJ0101.Forms
{
    partial class FormCreateZamestnanec
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
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.preid = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.Label();
            this.workgroup = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPerId = new System.Windows.Forms.TextBox();
            this.meno = new System.Windows.Forms.Label();
            this.prie = new System.Windows.Forms.Label();
            this.adre = new System.Windows.Forms.Label();
            this.rodn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboWork = new System.Windows.Forms.ComboBox();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.pohl = new System.Windows.Forms.Label();
            this.gru = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.Label();
            this.ptoj = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvypis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lmail = new System.Windows.Forms.Label();
            this.lheslo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vytvorit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(77, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Meno";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(77, 75);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(72, 17);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Priezvisko";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(77, 113);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(53, 17);
            this.address.TabIndex = 3;
            this.address.Text = "Adresa";
            // 
            // preid
            // 
            this.preid.AutoSize = true;
            this.preid.Location = new System.Drawing.Point(77, 162);
            this.preid.Name = "preid";
            this.preid.Size = new System.Drawing.Size(82, 17);
            this.preid.TabIndex = 4;
            this.preid.Text = "Rodne cislo";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(77, 214);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(62, 17);
            this.sex.TabIndex = 5;
            this.sex.Text = "Pohlavie";
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(77, 262);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(59, 17);
            this.group.TabIndex = 6;
            this.group.Text = "Skupina";
            // 
            // workgroup
            // 
            this.workgroup.AutoSize = true;
            this.workgroup.Location = new System.Drawing.Point(77, 308);
            this.workgroup.Name = "workgroup";
            this.workgroup.Size = new System.Drawing.Size(77, 17);
            this.workgroup.TabIndex = 7;
            this.workgroup.Text = "Pracovisko";
            // 
            // project
            // 
            this.project.AutoSize = true;
            this.project.Location = new System.Drawing.Point(77, 354);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(52, 17);
            this.project.TabIndex = 8;
            this.project.Text = "Projekt";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(194, 32);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 22);
            this.textName.TabIndex = 13;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textLast
            // 
            this.textLast.Location = new System.Drawing.Point(194, 75);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(121, 22);
            this.textLast.TabIndex = 14;
            this.textLast.TextChanged += new System.EventHandler(this.textLast_TextChanged);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(194, 113);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(121, 22);
            this.textAddress.TabIndex = 15;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // textPerId
            // 
            this.textPerId.Location = new System.Drawing.Point(194, 162);
            this.textPerId.Name = "textPerId";
            this.textPerId.Size = new System.Drawing.Size(121, 22);
            this.textPerId.TabIndex = 16;
            this.textPerId.TextChanged += new System.EventHandler(this.textPerId_TextChanged);
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.ForeColor = System.Drawing.Color.DarkRed;
            this.meno.Location = new System.Drawing.Point(342, 31);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(0, 17);
            this.meno.TabIndex = 17;
            // 
            // prie
            // 
            this.prie.AutoSize = true;
            this.prie.ForeColor = System.Drawing.Color.DarkRed;
            this.prie.Location = new System.Drawing.Point(345, 79);
            this.prie.Name = "prie";
            this.prie.Size = new System.Drawing.Size(0, 17);
            this.prie.TabIndex = 18;
            // 
            // adre
            // 
            this.adre.AutoSize = true;
            this.adre.ForeColor = System.Drawing.Color.DarkRed;
            this.adre.Location = new System.Drawing.Point(345, 117);
            this.adre.Name = "adre";
            this.adre.Size = new System.Drawing.Size(0, 17);
            this.adre.TabIndex = 19;
            // 
            // rodn
            // 
            this.rodn.AutoSize = true;
            this.rodn.ForeColor = System.Drawing.Color.DarkRed;
            this.rodn.Location = new System.Drawing.Point(345, 166);
            this.rodn.Name = "rodn";
            this.rodn.Size = new System.Drawing.Size(0, 17);
            this.rodn.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 446);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 484);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Heslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Vypis";
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(194, 262);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(121, 24);
            this.comboGroup.TabIndex = 9;
            this.comboGroup.SelectedIndexChanged += new System.EventHandler(this.comboGroup_SelectedIndexChanged);
            // 
            // comboWork
            // 
            this.comboWork.FormattingEnabled = true;
            this.comboWork.Location = new System.Drawing.Point(194, 305);
            this.comboWork.Name = "comboWork";
            this.comboWork.Size = new System.Drawing.Size(121, 24);
            this.comboWork.TabIndex = 10;
            this.comboWork.SelectedIndexChanged += new System.EventHandler(this.comboWork_SelectedIndexChanged);
            // 
            // comboProject
            // 
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(194, 354);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(121, 24);
            this.comboProject.TabIndex = 11;
            this.comboProject.SelectedIndexChanged += new System.EventHandler(this.comboProject_SelectedIndexChanged);
            // 
            // comboSex
            // 
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "muž",
            "žena"});
            this.comboSex.Location = new System.Drawing.Point(194, 214);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(121, 24);
            this.comboSex.TabIndex = 12;
            this.comboSex.SelectedIndexChanged += new System.EventHandler(this.comboSex_SelectedIndexChanged);
            // 
            // pohl
            // 
            this.pohl.AutoSize = true;
            this.pohl.ForeColor = System.Drawing.Color.DarkRed;
            this.pohl.Location = new System.Drawing.Point(342, 214);
            this.pohl.Name = "pohl";
            this.pohl.Size = new System.Drawing.Size(0, 17);
            this.pohl.TabIndex = 21;
            // 
            // gru
            // 
            this.gru.AutoSize = true;
            this.gru.ForeColor = System.Drawing.Color.DarkRed;
            this.gru.Location = new System.Drawing.Point(332, 262);
            this.gru.Name = "gru";
            this.gru.Size = new System.Drawing.Size(0, 17);
            this.gru.TabIndex = 22;
            // 
            // work
            // 
            this.work.AutoSize = true;
            this.work.ForeColor = System.Drawing.Color.DarkRed;
            this.work.Location = new System.Drawing.Point(332, 308);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(0, 17);
            this.work.TabIndex = 23;
            // 
            // ptoj
            // 
            this.ptoj.AutoSize = true;
            this.ptoj.ForeColor = System.Drawing.Color.DarkRed;
            this.ptoj.Location = new System.Drawing.Point(332, 357);
            this.ptoj.Name = "ptoj";
            this.ptoj.Size = new System.Drawing.Size(0, 17);
            this.ptoj.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 406);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(273, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 34;
            // 
            // lvypis
            // 
            this.lvypis.AutoSize = true;
            this.lvypis.ForeColor = System.Drawing.Color.DarkRed;
            this.lvypis.Location = new System.Drawing.Point(332, 484);
            this.lvypis.Name = "lvypis";
            this.lvypis.Size = new System.Drawing.Size(0, 17);
            this.lvypis.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(270, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 33;
            // 
            // lmail
            // 
            this.lmail.AutoSize = true;
            this.lmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lmail.Location = new System.Drawing.Point(332, 406);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(0, 17);
            this.lmail.TabIndex = 31;
            // 
            // lheslo
            // 
            this.lheslo.AutoSize = true;
            this.lheslo.ForeColor = System.Drawing.Color.DarkRed;
            this.lheslo.Location = new System.Drawing.Point(338, 451);
            this.lheslo.Name = "lheslo";
            this.lheslo.Size = new System.Drawing.Size(0, 17);
            this.lheslo.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(338, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 35;
            // 
            // FormCreateZamestnanec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 615);
            this.Controls.Add(this.lheslo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvypis);
            this.Controls.Add(this.lmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptoj);
            this.Controls.Add(this.work);
            this.Controls.Add(this.gru);
            this.Controls.Add(this.pohl);
            this.Controls.Add(this.rodn);
            this.Controls.Add(this.adre);
            this.Controls.Add(this.prie);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.textPerId);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.comboProject);
            this.Controls.Add(this.comboWork);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.project);
            this.Controls.Add(this.workgroup);
            this.Controls.Add(this.group);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.preid);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Name = "FormCreateZamestnanec";
            this.Text = "FormCreateZamestnanec";
            this.Load += new System.EventHandler(this.FormCreateZamestnanec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label preid;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label group;
        private System.Windows.Forms.Label workgroup;
        private System.Windows.Forms.Label project;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPerId;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label prie;
        private System.Windows.Forms.Label adre;
        private System.Windows.Forms.Label rodn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboWork;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.Label pohl;
        private System.Windows.Forms.Label gru;
        private System.Windows.Forms.Label work;
        private System.Windows.Forms.Label ptoj;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lvypis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lmail;
        private System.Windows.Forms.Label lheslo;
        private System.Windows.Forms.Label label5;
    }
}