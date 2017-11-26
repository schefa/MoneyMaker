namespace MoneyMaker.Views.Tables
{
    partial class LoanCalculatorTable
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
            this.colDebtLastYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRates = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRates2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRedemption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDebtAtEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTable
            // 
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMonth,
            this.colDebtLastYear,
            this.colRates,
            this.colRates2,
            this.colRedemption,
            this.colDebtAtEnd});
            this.lvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTable.Location = new System.Drawing.Point(0, 0);
            this.lvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(988, 665);
            this.lvTable.TabIndex = 0;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            // 
            // colMonth
            // 
            this.colMonth.Text = "Monat";
            // 
            // colDebtLastYear
            // 
            this.colDebtLastYear.Text = "Schuldenstand";
            this.colDebtLastYear.Width = 110;
            // 
            // colRates
            // 
            this.colRates.Text = "Ratenzahlungen";
            this.colRates.Width = 110;
            // 
            // colRates2
            // 
            this.colRates2.Text = "davon Zinsen/Gebühren";
            this.colRates2.Width = 130;
            // 
            // colRedemption
            // 
            this.colRedemption.Text = "Tilgung";
            this.colRedemption.Width = 102;
            // 
            // colDebtAtEnd
            // 
            this.colDebtAtEnd.Text = "Schuldenstand am Monatsende";
            this.colDebtAtEnd.Width = 164;
            // 
            // LoanCalculatorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 665);
            this.Controls.Add(this.lvTable);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoanCalculatorTable";
            this.Text = "Kreditrechner - Ergebnisse";
            this.Load += new System.EventHandler(this.LoanCalculatorTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ColumnHeader colMonth;
        private System.Windows.Forms.ColumnHeader colDebtLastYear;
        private System.Windows.Forms.ColumnHeader colRates;
        private System.Windows.Forms.ColumnHeader colRates2;
        private System.Windows.Forms.ColumnHeader colRedemption;
        private System.Windows.Forms.ColumnHeader colDebtAtEnd;
    }
}