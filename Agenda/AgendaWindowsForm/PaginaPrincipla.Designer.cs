namespace AgendaWindowsForm
{
    partial class PaginaPrincipla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipla));
            this.addButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(103, 261);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(86, 84);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewButton.BackgroundImage")));
            this.viewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Location = new System.Drawing.Point(303, 261);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(86, 84);
            this.viewButton.TabIndex = 1;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // PaginaPrincipla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 397);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.addButton);
            this.Name = "PaginaPrincipla";
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewButton;
    }
}