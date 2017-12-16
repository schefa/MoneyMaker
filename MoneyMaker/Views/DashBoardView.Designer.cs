namespace MoneyMaker.Views
{
    partial class DashBoardView
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
            this.pbMMLogo = new System.Windows.Forms.PictureBox();
            this.lblMoneyMaker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMMLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMMLogo
            // 
            this.pbMMLogo.Image = global::MoneyMaker.Properties.Resources.logo;
            this.pbMMLogo.Location = new System.Drawing.Point(311, 147);
            this.pbMMLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMMLogo.Name = "pbMMLogo";
            this.pbMMLogo.Size = new System.Drawing.Size(83, 82);
            this.pbMMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMMLogo.TabIndex = 30;
            this.pbMMLogo.TabStop = false;
            // 
            // lblMoneyMaker
            // 
            this.lblMoneyMaker.Font = new System.Drawing.Font("Tw Cen MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyMaker.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMoneyMaker.Location = new System.Drawing.Point(140, 266);
            this.lblMoneyMaker.Name = "lblMoneyMaker";
            this.lblMoneyMaker.Size = new System.Drawing.Size(437, 82);
            this.lblMoneyMaker.TabIndex = 31;
            this.lblMoneyMaker.Text = "MoneyMaker";
            // 
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pbMMLogo);
            this.Controls.Add(this.lblMoneyMaker);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashBoardView";
            this.Size = new System.Drawing.Size(788, 408);
            ((System.ComponentModel.ISupportInitialize)(this.pbMMLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMoneyMaker;
        private System.Windows.Forms.PictureBox pbMMLogo;
    }
}
