namespace AgendaWindowsForm
{
    partial class FiltrareData
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
            this.dataDela = new System.Windows.Forms.DateTimePicker();
            this.dataPanaLa = new System.Windows.Forms.DateTimePicker();
            this.lblDela = new System.Windows.Forms.Label();
            this.lblPanaLa = new System.Windows.Forms.Label();
            this.btnCautare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataDela
            // 
            this.dataDela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDela.Location = new System.Drawing.Point(102, 62);
            this.dataDela.Name = "dataDela";
            this.dataDela.Size = new System.Drawing.Size(235, 30);
            this.dataDela.TabIndex = 0;
            this.dataDela.ValueChanged += new System.EventHandler(this.dataDela_ValueChanged);
            // 
            // dataPanaLa
            // 
            this.dataPanaLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPanaLa.Location = new System.Drawing.Point(102, 121);
            this.dataPanaLa.Name = "dataPanaLa";
            this.dataPanaLa.Size = new System.Drawing.Size(235, 30);
            this.dataPanaLa.TabIndex = 1;
            this.dataPanaLa.ValueChanged += new System.EventHandler(this.dataPanaLa_ValueChanged);
            // 
            // lblDela
            // 
            this.lblDela.AutoSize = true;
            this.lblDela.BackColor = System.Drawing.Color.Transparent;
            this.lblDela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDela.Location = new System.Drawing.Point(12, 62);
            this.lblDela.Name = "lblDela";
            this.lblDela.Size = new System.Drawing.Size(63, 25);
            this.lblDela.TabIndex = 2;
            this.lblDela.Text = "De la:";
            // 
            // lblPanaLa
            // 
            this.lblPanaLa.AutoSize = true;
            this.lblPanaLa.BackColor = System.Drawing.Color.Transparent;
            this.lblPanaLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanaLa.Location = new System.Drawing.Point(12, 121);
            this.lblPanaLa.Name = "lblPanaLa";
            this.lblPanaLa.Size = new System.Drawing.Size(84, 25);
            this.lblPanaLa.TabIndex = 3;
            this.lblPanaLa.Text = "Pana la:";
            // 
            // btnCautare
            // 
            this.btnCautare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCautare.Location = new System.Drawing.Point(102, 238);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(159, 70);
            this.btnCautare.TabIndex = 4;
            this.btnCautare.Text = "CAUTA";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // FiltrareData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AgendaWindowsForm.Properties.Resources.istockphoto_907579860_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 320);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.lblPanaLa);
            this.Controls.Add(this.lblDela);
            this.Controls.Add(this.dataPanaLa);
            this.Controls.Add(this.dataDela);
            this.Name = "FiltrareData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiltrareData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataDela;
        private System.Windows.Forms.DateTimePicker dataPanaLa;
        private System.Windows.Forms.Label lblDela;
        private System.Windows.Forms.Label lblPanaLa;
        private System.Windows.Forms.Button btnCautare;
    }
}