namespace MoneyMaker.Views
{
    partial class LegalView
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
            this.rtbLegal = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbLegal
            // 
            this.rtbLegal.BackColor = System.Drawing.SystemColors.Window;
            this.rtbLegal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLegal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLegal.Location = new System.Drawing.Point(3, 3);
            this.rtbLegal.Name = "rtbLegal";
            this.rtbLegal.ReadOnly = true;
            this.rtbLegal.Size = new System.Drawing.Size(872, 464);
            this.rtbLegal.TabIndex = 0;
            this.rtbLegal.Text = "Copyright by Fjodor Schäfer, Niclas Jansen, Jan-Erik Franzen, Oliver Ruch, Artak " +
    "Melkonyan.\n\nBildverweise: \nhttps://www.iconfinder.com/justui\n\n\n\nAll Rights reser" +
    "ved";
            // 
            // LegalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbLegal);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LegalView";
            this.Size = new System.Drawing.Size(877, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLegal;
    }
}
