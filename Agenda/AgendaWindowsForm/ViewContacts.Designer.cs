namespace AgendaWindowsForm
{
    partial class ViewContacts
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
            this.components = new System.ComponentModel.Container();
            this.contactsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.meniuLista = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrareDataActualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.lblCauta = new System.Windows.Forms.Label();
            this.cautaImagine = new System.Windows.Forms.PictureBox();
            this.panouAfisare = new System.Windows.Forms.Panel();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDataNasterii = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtGrup = new System.Windows.Forms.TextBox();
            this.lblGrup = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.filtrareDupaGrupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cautaImagine)).BeginInit();
            this.panouAfisare.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsList
            // 
            this.contactsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.contactsList.ContextMenuStrip = this.meniuLista;
            this.contactsList.FullRowSelect = true;
            this.contactsList.GridLines = true;
            this.contactsList.Location = new System.Drawing.Point(13, 33);
            this.contactsList.Name = "contactsList";
            this.contactsList.Size = new System.Drawing.Size(361, 423);
            this.contactsList.TabIndex = 0;
            this.contactsList.UseCompatibleStateImageBehavior = false;
            this.contactsList.View = System.Windows.Forms.View.Details;
            this.contactsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contactsList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 100;
            // 
            // meniuLista
            // 
            this.meniuLista.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.meniuLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetareToolStripMenuItem,
            this.filtrareDataActualizareToolStripMenuItem,
            this.filtrareDupaGrupToolStripMenuItem});
            this.meniuLista.Name = "meniuLista";
            this.meniuLista.Size = new System.Drawing.Size(239, 104);
            // 
            // resetareToolStripMenuItem
            // 
            this.resetareToolStripMenuItem.Name = "resetareToolStripMenuItem";
            this.resetareToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.resetareToolStripMenuItem.Text = "Resetare";
            this.resetareToolStripMenuItem.Click += new System.EventHandler(this.resetareToolStripMenuItem_Click);
            // 
            // filtrareDataActualizareToolStripMenuItem
            // 
            this.filtrareDataActualizareToolStripMenuItem.Name = "filtrareDataActualizareToolStripMenuItem";
            this.filtrareDataActualizareToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.filtrareDataActualizareToolStripMenuItem.Text = "Filtrare Data Actualizare";
            this.filtrareDataActualizareToolStripMenuItem.Click += new System.EventHandler(this.filtrareDataActualizareToolStripMenuItem_Click);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(107, 5);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(267, 22);
            this.txtCautare.TabIndex = 1;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Location = new System.Drawing.Point(13, 5);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(66, 17);
            this.lblCauta.TabIndex = 2;
            this.lblCauta.Text = "Cautare :";
            // 
            // cautaImagine
            // 
            this.cautaImagine.Image = global::AgendaWindowsForm.Properties.Resources.download;
            this.cautaImagine.Location = new System.Drawing.Point(77, 5);
            this.cautaImagine.Name = "cautaImagine";
            this.cautaImagine.Size = new System.Drawing.Size(23, 21);
            this.cautaImagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cautaImagine.TabIndex = 3;
            this.cautaImagine.TabStop = false;
            // 
            // panouAfisare
            // 
            this.panouAfisare.BackColor = System.Drawing.SystemColors.Control;
            this.panouAfisare.BackgroundImage = global::AgendaWindowsForm.Properties.Resources.info_user;
            this.panouAfisare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panouAfisare.Controls.Add(this.txtGen);
            this.panouAfisare.Controls.Add(this.lblGen);
            this.panouAfisare.Controls.Add(this.btnEdit);
            this.panouAfisare.Controls.Add(this.txtDataNasterii);
            this.panouAfisare.Controls.Add(this.lblData);
            this.panouAfisare.Controls.Add(this.txtGrup);
            this.panouAfisare.Controls.Add(this.lblGrup);
            this.panouAfisare.Controls.Add(this.txtEmail);
            this.panouAfisare.Controls.Add(this.lblEmail);
            this.panouAfisare.Controls.Add(this.txtTelefon);
            this.panouAfisare.Controls.Add(this.lblTelefon);
            this.panouAfisare.Controls.Add(this.txtPrenume);
            this.panouAfisare.Controls.Add(this.lblPrenume);
            this.panouAfisare.Controls.Add(this.txtNume);
            this.panouAfisare.Controls.Add(this.lblNume);
            this.panouAfisare.Location = new System.Drawing.Point(380, 5);
            this.panouAfisare.Name = "panouAfisare";
            this.panouAfisare.Size = new System.Drawing.Size(430, 451);
            this.panouAfisare.TabIndex = 4;
            // 
            // txtGen
            // 
            this.txtGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGen.Location = new System.Drawing.Point(107, 267);
            this.txtGen.Name = "txtGen";
            this.txtGen.ReadOnly = true;
            this.txtGen.Size = new System.Drawing.Size(314, 30);
            this.txtGen.TabIndex = 14;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(8, 270);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(49, 25);
            this.lblGen.TabIndex = 13;
            this.lblGen.Text = "Gen";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::AgendaWindowsForm.Properties.Resources.Edit_Male_User_icon;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(107, 319);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 81);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDataNasterii
            // 
            this.txtDataNasterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNasterii.Location = new System.Drawing.Point(107, 221);
            this.txtDataNasterii.Name = "txtDataNasterii";
            this.txtDataNasterii.ReadOnly = true;
            this.txtDataNasterii.Size = new System.Drawing.Size(314, 30);
            this.txtDataNasterii.TabIndex = 11;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(3, 224);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(99, 25);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "D.Nastere";
            // 
            // txtGrup
            // 
            this.txtGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrup.Location = new System.Drawing.Point(107, 176);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.ReadOnly = true;
            this.txtGrup.Size = new System.Drawing.Size(314, 30);
            this.txtGrup.TabIndex = 9;
            // 
            // lblGrup
            // 
            this.lblGrup.AutoSize = true;
            this.lblGrup.BackColor = System.Drawing.Color.Transparent;
            this.lblGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrup.Location = new System.Drawing.Point(3, 176);
            this.lblGrup.Name = "lblGrup";
            this.lblGrup.Size = new System.Drawing.Size(55, 25);
            this.lblGrup.TabIndex = 8;
            this.lblGrup.Text = "Grup";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(107, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(314, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(107, 89);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(314, 30);
            this.txtTelefon.TabIndex = 5;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(3, 92);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(78, 25);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(107, 42);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.ReadOnly = true;
            this.txtPrenume.Size = new System.Drawing.Size(314, 30);
            this.txtPrenume.TabIndex = 3;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenume.Location = new System.Drawing.Point(3, 45);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(91, 25);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(107, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.ReadOnly = true;
            this.txtNume.Size = new System.Drawing.Size(314, 30);
            this.txtNume.TabIndex = 1;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(3, 5);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(64, 25);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // filtrareDupaGrupToolStripMenuItem
            // 
            this.filtrareDupaGrupToolStripMenuItem.Name = "filtrareDupaGrupToolStripMenuItem";
            this.filtrareDupaGrupToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.filtrareDupaGrupToolStripMenuItem.Text = "Filtrare Dupa Grup";
            this.filtrareDupaGrupToolStripMenuItem.Click += new System.EventHandler(this.filtrareDupaGrupToolStripMenuItem_Click);
            // 
            // ViewContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(822, 468);
            this.Controls.Add(this.panouAfisare);
            this.Controls.Add(this.cautaImagine);
            this.Controls.Add(this.lblCauta);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.contactsList);
            this.Name = "ViewContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewContacts";
            this.Load += new System.EventHandler(this.ViewContacts_Load);
            this.meniuLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cautaImagine)).EndInit();
            this.panouAfisare.ResumeLayout(false);
            this.panouAfisare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView contactsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label lblCauta;
        private System.Windows.Forms.PictureBox cautaImagine;
        private System.Windows.Forms.Panel panouAfisare;
        private System.Windows.Forms.TextBox txtDataNasterii;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtGrup;
        private System.Windows.Forms.Label lblGrup;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ContextMenuStrip meniuLista;
        private System.Windows.Forms.ToolStripMenuItem resetareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrareDataActualizareToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.ToolStripMenuItem filtrareDupaGrupToolStripMenuItem;
    }
}