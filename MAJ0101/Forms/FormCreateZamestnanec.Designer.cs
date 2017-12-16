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
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.comboWork = new System.Windows.Forms.ComboBox();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLast = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPerId = new System.Windows.Forms.TextBox();
            this.meno = new System.Windows.Forms.Label();
            this.prie = new System.Windows.Forms.Label();
            this.adre = new System.Windows.Forms.Label();
            this.rodn = new System.Windows.Forms.Label();
            this.pohl = new System.Windows.Forms.Label();
            this.gru = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.Label();
            this.ptoj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 411);
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
            this.comboWork.Location = new System.Drawing.Point(194, 308);
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
            // pohl
            // 
            this.pohl.AutoSize = true;
            this.pohl.ForeColor = System.Drawing.Color.DarkRed;
            this.pohl.Location = new System.Drawing.Point(348, 220);
            this.pohl.Name = "pohl";
            this.pohl.Size = new System.Drawing.Size(0, 17);
            this.pohl.TabIndex = 21;
            // 
            // gru
            // 
            this.gru.AutoSize = true;
            this.gru.ForeColor = System.Drawing.Color.DarkRed;
            this.gru.Location = new System.Drawing.Point(345, 262);
            this.gru.Name = "gru";
            this.gru.Size = new System.Drawing.Size(0, 17);
            this.gru.TabIndex = 22;
            // 
            // work
            // 
            this.work.AutoSize = true;
            this.work.ForeColor = System.Drawing.Color.DarkRed;
            this.work.Location = new System.Drawing.Point(351, 314);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(0, 17);
            this.work.TabIndex = 23;
            // 
            // ptoj
            // 
            this.ptoj.AutoSize = true;
            this.ptoj.ForeColor = System.Drawing.Color.DarkRed;
            this.ptoj.Location = new System.Drawing.Point(354, 360);
            this.ptoj.Name = "ptoj";
            this.ptoj.Size = new System.Drawing.Size(0, 17);
            this.ptoj.TabIndex = 24;
            // 
            // FormCreateZamestnanec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 458);
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
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboWork;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.ComboBox comboSex;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLast;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPerId;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label prie;
        private System.Windows.Forms.Label adre;
        private System.Windows.Forms.Label rodn;
        private System.Windows.Forms.Label pohl;
        private System.Windows.Forms.Label gru;
        private System.Windows.Forms.Label work;
        private System.Windows.Forms.Label ptoj;
    }
}