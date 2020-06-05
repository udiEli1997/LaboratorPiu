namespace AgendaWindowsForm
{
    partial class FiltrareGrup
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
            this.gbGrup = new System.Windows.Forms.GroupBox();
            this.ckbPrieteni = new System.Windows.Forms.CheckBox();
            this.ckbFamilie = new System.Windows.Forms.CheckBox();
            this.ckbServici = new System.Windows.Forms.CheckBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.gbGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGrup
            // 
            this.gbGrup.BackColor = System.Drawing.Color.Transparent;
            this.gbGrup.Controls.Add(this.ckbServici);
            this.gbGrup.Controls.Add(this.ckbFamilie);
            this.gbGrup.Controls.Add(this.ckbPrieteni);
            this.gbGrup.Location = new System.Drawing.Point(70, 33);
            this.gbGrup.Name = "gbGrup";
            this.gbGrup.Size = new System.Drawing.Size(247, 255);
            this.gbGrup.TabIndex = 0;
            this.gbGrup.TabStop = false;
            this.gbGrup.Text = "Grup:";
            // 
            // ckbPrieteni
            // 
            this.ckbPrieteni.AutoSize = true;
            this.ckbPrieteni.Location = new System.Drawing.Point(69, 21);
            this.ckbPrieteni.Name = "ckbPrieteni";
            this.ckbPrieteni.Size = new System.Drawing.Size(78, 21);
            this.ckbPrieteni.TabIndex = 0;
            this.ckbPrieteni.Text = "Prieteni";
            this.ckbPrieteni.UseVisualStyleBackColor = true;
            // 
            // ckbFamilie
            // 
            this.ckbFamilie.AutoSize = true;
            this.ckbFamilie.Location = new System.Drawing.Point(73, 103);
            this.ckbFamilie.Name = "ckbFamilie";
            this.ckbFamilie.Size = new System.Drawing.Size(74, 21);
            this.ckbFamilie.TabIndex = 1;
            this.ckbFamilie.Text = "Familie";
            this.ckbFamilie.UseVisualStyleBackColor = true;
            // 
            // ckbServici
            // 
            this.ckbServici.AutoSize = true;
            this.ckbServici.Location = new System.Drawing.Point(69, 182);
            this.ckbServici.Name = "ckbServici";
            this.ckbServici.Size = new System.Drawing.Size(72, 21);
            this.ckbServici.TabIndex = 2;
            this.ckbServici.Text = "Servici";
            this.ckbServici.UseVisualStyleBackColor = true;
            // 
            // btnCauta
            // 
            this.btnCauta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCauta.Location = new System.Drawing.Point(121, 295);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(154, 37);
            this.btnCauta.TabIndex = 1;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // FiltrareGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AgendaWindowsForm.Properties.Resources.istockphoto_907579860_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 344);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.gbGrup);
            this.Name = "FiltrareGrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltrareGrup";
            this.gbGrup.ResumeLayout(false);
            this.gbGrup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGrup;
        private System.Windows.Forms.CheckBox ckbServici;
        private System.Windows.Forms.CheckBox ckbFamilie;
        private System.Windows.Forms.CheckBox ckbPrieteni;
        private System.Windows.Forms.Button btnCauta;
    }
}