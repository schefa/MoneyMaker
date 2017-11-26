namespace MoneyMaker.Views
{
    partial class StockDetailsView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.lblDateInput = new System.Windows.Forms.Label();
            this.lblOpenInput = new System.Windows.Forms.Label();
            this.lblCloseInput = new System.Windows.Forms.Label();
            this.lblVolumeInput = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Location = new System.Drawing.Point(89, 1);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(16, 15);
            this.lblNameInput.TabIndex = 2;
            this.lblNameInput.Text = "...";
            // 
            // lblDateInput
            // 
            this.lblDateInput.AutoSize = true;
            this.lblDateInput.Location = new System.Drawing.Point(89, 38);
            this.lblDateInput.Name = "lblDateInput";
            this.lblDateInput.Size = new System.Drawing.Size(16, 15);
            this.lblDateInput.TabIndex = 3;
            this.lblDateInput.Text = "...";
            // 
            // lblOpenInput
            // 
            this.lblOpenInput.AutoSize = true;
            this.lblOpenInput.Location = new System.Drawing.Point(89, 76);
            this.lblOpenInput.Name = "lblOpenInput";
            this.lblOpenInput.Size = new System.Drawing.Size(16, 15);
            this.lblOpenInput.TabIndex = 4;
            this.lblOpenInput.Text = "...";
            // 
            // lblCloseInput
            // 
            this.lblCloseInput.AutoSize = true;
            this.lblCloseInput.Location = new System.Drawing.Point(89, 151);
            this.lblCloseInput.Name = "lblCloseInput";
            this.lblCloseInput.Size = new System.Drawing.Size(16, 15);
            this.lblCloseInput.TabIndex = 5;
            this.lblCloseInput.Text = "...";
            // 
            // lblVolumeInput
            // 
            this.lblVolumeInput.AutoSize = true;
            this.lblVolumeInput.Location = new System.Drawing.Point(89, 113);
            this.lblVolumeInput.Name = "lblVolumeInput";
            this.lblVolumeInput.Size = new System.Drawing.Size(16, 15);
            this.lblVolumeInput.TabIndex = 6;
            this.lblVolumeInput.Text = "...";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(3, 113);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(47, 15);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Volume";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 15);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Datum";
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Location = new System.Drawing.Point(4, 151);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(32, 15);
            this.lblCurrentPrice.TabIndex = 10;
            this.lblCurrentPrice.Text = "Preis";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Location = new System.Drawing.Point(3, 76);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(36, 15);
            this.lblOpen.TabIndex = 9;
            this.lblOpen.Text = "Open";
            // 
            // StockDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.lblDateInput);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblOpenInput);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.lblCloseInput);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblVolumeInput);
            this.Controls.Add(this.lblVolume);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StockDetailsView";
            this.Size = new System.Drawing.Size(114, 178);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Label lblDateInput;
        private System.Windows.Forms.Label lblOpenInput;
        private System.Windows.Forms.Label lblCloseInput;
        private System.Windows.Forms.Label lblVolumeInput;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Label lblOpen;
    }
}
