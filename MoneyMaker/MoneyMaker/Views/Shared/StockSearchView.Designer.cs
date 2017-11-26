namespace MoneyMaker.Views
{
    partial class StockSearchView
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
            this.components = new System.ComponentModel.Container();
            this.cbMultiLine = new System.Windows.Forms.ComboBox();
            this.searchTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cbMultiLine
            // 
            this.cbMultiLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMultiLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMultiLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMultiLine.DropDownHeight = 300;
            this.cbMultiLine.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMultiLine.FormattingEnabled = true;
            this.cbMultiLine.IntegralHeight = false;
            this.cbMultiLine.Location = new System.Drawing.Point(0, 0);
            this.cbMultiLine.Margin = new System.Windows.Forms.Padding(2);
            this.cbMultiLine.Name = "cbMultiLine";
            this.cbMultiLine.Size = new System.Drawing.Size(193, 28);
            this.cbMultiLine.TabIndex = 10;
            this.searchTooltip.SetToolTip(this.cbMultiLine, "Geben Sie hier einen Suchbegriff für das Wertpapier ein");
            this.cbMultiLine.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbMultiLine_DrawItem);
            this.cbMultiLine.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cbMultiLine_MeasureItem);
            this.cbMultiLine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbMultiLine_KeyUp);
            // 
            // searchTooltip
            // 
            this.searchTooltip.AutoPopDelay = 5000;
            this.searchTooltip.InitialDelay = 200;
            this.searchTooltip.ReshowDelay = 100;
            // 
            // StockSearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMultiLine);
            this.Name = "StockSearchView";
            this.Size = new System.Drawing.Size(193, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMultiLine;
        private System.Windows.Forms.ToolTip searchTooltip;
    }
}
