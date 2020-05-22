namespace AgendaWindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addPanel = new System.Windows.Forms.Panel();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.lblDataNasterii = new System.Windows.Forms.Label();
            this.gbGrup = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbServici = new System.Windows.Forms.CheckBox();
            this.ckbPrieteni = new System.Windows.Forms.CheckBox();
            this.dataNastere = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbGen = new System.Windows.Forms.GroupBox();
            this.rbMasculin = new System.Windows.Forms.RadioButton();
            this.rbFeminin = new System.Windows.Forms.RadioButton();
            this.addPanel.SuspendLayout();
            this.gbGrup.SuspendLayout();
            this.gbGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.gbGen);
            this.addPanel.Controls.Add(this.btnAdaugare);
            this.addPanel.Controls.Add(this.lblDataNasterii);
            this.addPanel.Controls.Add(this.gbGrup);
            this.addPanel.Controls.Add(this.dataNastere);
            this.addPanel.Controls.Add(this.txtEmail);
            this.addPanel.Controls.Add(this.txtTelefon);
            this.addPanel.Controls.Add(this.txtPrenume);
            this.addPanel.Controls.Add(this.txtName);
            this.addPanel.Location = new System.Drawing.Point(96, 69);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(425, 452);
            this.addPanel.TabIndex = 8;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(127, 403);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(164, 46);
            this.btnAdaugare.TabIndex = 9;
            this.btnAdaugare.Text = "Adauga";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // lblDataNasterii
            // 
            this.lblDataNasterii.AutoSize = true;
            this.lblDataNasterii.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNasterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasterii.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDataNasterii.Location = new System.Drawing.Point(78, 288);
            this.lblDataNasterii.Name = "lblDataNasterii";
            this.lblDataNasterii.Size = new System.Drawing.Size(123, 25);
            this.lblDataNasterii.TabIndex = 8;
            this.lblDataNasterii.Text = "Data Nasterii";
            // 
            // gbGrup
            // 
            this.gbGrup.BackColor = System.Drawing.Color.Transparent;
            this.gbGrup.Controls.Add(this.checkBox1);
            this.gbGrup.Controls.Add(this.ckbServici);
            this.gbGrup.Controls.Add(this.ckbPrieteni);
            this.gbGrup.Location = new System.Drawing.Point(78, 181);
            this.gbGrup.Name = "gbGrup";
            this.gbGrup.Size = new System.Drawing.Size(276, 100);
            this.gbGrup.TabIndex = 7;
            this.gbGrup.TabStop = false;
            this.gbGrup.Text = "Grup:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(196, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Familie";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // ckbServici
            // 
            this.ckbServici.AutoSize = true;
            this.ckbServici.BackColor = System.Drawing.Color.Transparent;
            this.ckbServici.Location = new System.Drawing.Point(104, 35);
            this.ckbServici.Name = "ckbServici";
            this.ckbServici.Size = new System.Drawing.Size(72, 21);
            this.ckbServici.TabIndex = 1;
            this.ckbServici.Text = "Servici";
            this.ckbServici.UseVisualStyleBackColor = false;
            // 
            // ckbPrieteni
            // 
            this.ckbPrieteni.AutoSize = true;
            this.ckbPrieteni.BackColor = System.Drawing.Color.Transparent;
            this.ckbPrieteni.Location = new System.Drawing.Point(7, 35);
            this.ckbPrieteni.Name = "ckbPrieteni";
            this.ckbPrieteni.Size = new System.Drawing.Size(78, 21);
            this.ckbPrieteni.TabIndex = 0;
            this.ckbPrieteni.Text = "Prieteni";
            this.ckbPrieteni.UseVisualStyleBackColor = false;
            // 
            // dataNastere
            // 
            this.dataNastere.Location = new System.Drawing.Point(78, 315);
            this.dataNastere.Name = "dataNastere";
            this.dataNastere.Size = new System.Drawing.Size(276, 22);
            this.dataNastere.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(78, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 30);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefon.Location = new System.Drawing.Point(78, 106);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(276, 30);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.Text = "Telefon";
            this.txtTelefon.Enter += new System.EventHandler(this.txtTelefon_Enter);
            this.txtTelefon.Leave += new System.EventHandler(this.txtTelefon_Leave);
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrenume.Location = new System.Drawing.Point(78, 66);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(276, 30);
            this.txtPrenume.TabIndex = 3;
            this.txtPrenume.Text = "Prenume";
            this.txtPrenume.Enter += new System.EventHandler(this.txtPrenume_Enter);
            this.txtPrenume.Leave += new System.EventHandler(this.txtPrenume_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DarkGray;
            this.txtName.Location = new System.Drawing.Point(78, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 30);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Nume";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // gbGen
            // 
            this.gbGen.BackColor = System.Drawing.Color.Transparent;
            this.gbGen.Controls.Add(this.rbFeminin);
            this.gbGen.Controls.Add(this.rbMasculin);
            this.gbGen.Location = new System.Drawing.Point(78, 344);
            this.gbGen.Name = "gbGen";
            this.gbGen.Size = new System.Drawing.Size(276, 53);
            this.gbGen.TabIndex = 10;
            this.gbGen.TabStop = false;
            this.gbGen.Text = "Gen:";
            // 
            // rbMasculin
            // 
            this.rbMasculin.AutoSize = true;
            this.rbMasculin.Location = new System.Drawing.Point(49, 21);
            this.rbMasculin.Name = "rbMasculin";
            this.rbMasculin.Size = new System.Drawing.Size(40, 21);
            this.rbMasculin.TabIndex = 0;
            this.rbMasculin.TabStop = true;
            this.rbMasculin.Text = "M";
            this.rbMasculin.UseVisualStyleBackColor = true;
            // 
            // rbFeminin
            // 
            this.rbFeminin.AutoSize = true;
            this.rbFeminin.Location = new System.Drawing.Point(176, 22);
            this.rbFeminin.Name = "rbFeminin";
            this.rbFeminin.Size = new System.Drawing.Size(37, 21);
            this.rbFeminin.TabIndex = 1;
            this.rbFeminin.TabStop = true;
            this.rbFeminin.Text = "F";
            this.rbFeminin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 563);
            this.Controls.Add(this.addPanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agenda Telefonica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.gbGrup.ResumeLayout(false);
            this.gbGrup.PerformLayout();
            this.gbGen.ResumeLayout(false);
            this.gbGen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbGrup;
        private System.Windows.Forms.DateTimePicker dataNastere;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblDataNasterii;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbServici;
        private System.Windows.Forms.CheckBox ckbPrieteni;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.GroupBox gbGen;
        private System.Windows.Forms.RadioButton rbFeminin;
        private System.Windows.Forms.RadioButton rbMasculin;
    }
}

