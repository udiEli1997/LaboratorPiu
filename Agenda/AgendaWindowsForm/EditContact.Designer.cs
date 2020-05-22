namespace AgendaWindowsForm
{
    partial class EditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContact));
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbGrup = new System.Windows.Forms.GroupBox();
            this.ckFamilie = new System.Windows.Forms.CheckBox();
            this.ckServici = new System.Windows.Forms.CheckBox();
            this.ckPrieteni = new System.Windows.Forms.CheckBox();
            this.dataNasterii = new System.Windows.Forms.DateTimePicker();
            this.lblDataNastere = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMasculin = new System.Windows.Forms.RadioButton();
            this.rdbFeminin = new System.Windows.Forms.RadioButton();
            this.gbGrup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(12, 68);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(64, 25);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(12, 121);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(91, 25);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(12, 175);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(78, 25);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(109, 65);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(334, 30);
            this.txtNume.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(109, 116);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(334, 30);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(109, 175);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(334, 30);
            this.txtTelefon.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(109, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(12, 505);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 61);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(381, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 61);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbGrup
            // 
            this.gbGrup.BackColor = System.Drawing.Color.Transparent;
            this.gbGrup.Controls.Add(this.ckFamilie);
            this.gbGrup.Controls.Add(this.ckServici);
            this.gbGrup.Controls.Add(this.ckPrieteni);
            this.gbGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGrup.Location = new System.Drawing.Point(17, 273);
            this.gbGrup.Name = "gbGrup";
            this.gbGrup.Size = new System.Drawing.Size(417, 100);
            this.gbGrup.TabIndex = 10;
            this.gbGrup.TabStop = false;
            this.gbGrup.Text = "Grup";
            // 
            // ckFamilie
            // 
            this.ckFamilie.AutoSize = true;
            this.ckFamilie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckFamilie.Location = new System.Drawing.Point(315, 46);
            this.ckFamilie.Name = "ckFamilie";
            this.ckFamilie.Size = new System.Drawing.Size(96, 29);
            this.ckFamilie.TabIndex = 2;
            this.ckFamilie.Text = "Familie";
            this.ckFamilie.UseVisualStyleBackColor = true;
            // 
            // ckServici
            // 
            this.ckServici.AutoSize = true;
            this.ckServici.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckServici.Location = new System.Drawing.Point(163, 46);
            this.ckServici.Name = "ckServici";
            this.ckServici.Size = new System.Drawing.Size(93, 29);
            this.ckServici.TabIndex = 1;
            this.ckServici.Text = "Servici";
            this.ckServici.UseVisualStyleBackColor = true;
            // 
            // ckPrieteni
            // 
            this.ckPrieteni.AutoSize = true;
            this.ckPrieteni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckPrieteni.Location = new System.Drawing.Point(7, 46);
            this.ckPrieteni.Name = "ckPrieteni";
            this.ckPrieteni.Size = new System.Drawing.Size(99, 29);
            this.ckPrieteni.TabIndex = 0;
            this.ckPrieteni.Text = "Prieteni";
            this.ckPrieteni.UseVisualStyleBackColor = true;
            // 
            // dataNasterii
            // 
            this.dataNasterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataNasterii.Location = new System.Drawing.Point(169, 398);
            this.dataNasterii.Name = "dataNasterii";
            this.dataNasterii.Size = new System.Drawing.Size(265, 30);
            this.dataNasterii.TabIndex = 11;
            // 
            // lblDataNastere
            // 
            this.lblDataNastere.AutoSize = true;
            this.lblDataNastere.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNastere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNastere.Location = new System.Drawing.Point(17, 402);
            this.lblDataNastere.Name = "lblDataNastere";
            this.lblDataNastere.Size = new System.Drawing.Size(126, 25);
            this.lblDataNastere.TabIndex = 12;
            this.lblDataNastere.Text = "Data Nastere";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbFeminin);
            this.groupBox1.Controls.Add(this.rdbMasculin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gen";
            // 
            // rdbMasculin
            // 
            this.rdbMasculin.AutoSize = true;
            this.rdbMasculin.Location = new System.Drawing.Point(125, 27);
            this.rdbMasculin.Name = "rdbMasculin";
            this.rdbMasculin.Size = new System.Drawing.Size(50, 29);
            this.rdbMasculin.TabIndex = 0;
            this.rdbMasculin.TabStop = true;
            this.rdbMasculin.Text = "M";
            this.rdbMasculin.UseVisualStyleBackColor = true;
            // 
            // rdbFeminin
            // 
            this.rdbFeminin.AutoSize = true;
            this.rdbFeminin.Location = new System.Drawing.Point(253, 27);
            this.rdbFeminin.Name = "rdbFeminin";
            this.rdbFeminin.Size = new System.Drawing.Size(45, 29);
            this.rdbFeminin.TabIndex = 1;
            this.rdbFeminin.TabStop = true;
            this.rdbFeminin.Text = "F";
            this.rdbFeminin.UseVisualStyleBackColor = true;
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDataNastere);
            this.Controls.Add(this.dataNasterii);
            this.Controls.Add(this.gbGrup);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.DoubleBuffered = true;
            this.Name = "EditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditContact";
            this.gbGrup.ResumeLayout(false);
            this.gbGrup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbGrup;
        private System.Windows.Forms.DateTimePicker dataNasterii;
        private System.Windows.Forms.Label lblDataNastere;
        private System.Windows.Forms.CheckBox ckFamilie;
        private System.Windows.Forms.CheckBox ckServici;
        private System.Windows.Forms.CheckBox ckPrieteni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFeminin;
        private System.Windows.Forms.RadioButton rdbMasculin;
    }
}