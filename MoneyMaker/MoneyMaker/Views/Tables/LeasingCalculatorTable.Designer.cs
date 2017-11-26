namespace MoneyMaker.Views.Tables
{
    partial class LeasingCalculatorTable
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
            this.lvTable = new System.Windows.Forms.ListView();
            this.colMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecovery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTable
            // 
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMonth,
            this.colRate,
            this.colSum,
            this.colLoss,
            this.colRecovery});
            this.lvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTable.Location = new System.Drawing.Point(0, 0);
            this.lvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(818, 637);
            this.lvTable.TabIndex = 0;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            // 
            // colMonth
            // 
            this.colMonth.Text = "Monat";
            // 
            // colRate
            // 
            this.colRate.Text = "Rate";
            this.colRate.Width = 68;
            // 
            // colSum
            // 
            this.colSum.Text = "Summe";
            this.colSum.Width = 84;
            // 
            // colLoss
            // 
            this.colLoss.Text = "Wertverlust";
            this.colLoss.Width = 94;
            // 
            // colRecovery
            // 
            this.colRecovery.Text = "Restwert";
            this.colRecovery.Width = 88;
            // 
            // LeasingCalculatorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 637);
            this.Controls.Add(this.lvTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LeasingCalculatorTable";
            this.Text = "Leasingrechner - Ergebnisse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader colMonth;
        private System.Windows.Forms.ColumnHeader colRate;
        private System.Windows.Forms.ColumnHeader colSum;
        private System.Windows.Forms.ColumnHeader colLoss;
        private System.Windows.Forms.ColumnHeader colRecovery;
    }
}