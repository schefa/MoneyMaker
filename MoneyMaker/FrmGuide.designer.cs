using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMaker
{
    partial class FrmGuide
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuide));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.llVerrechungskonto = new System.Windows.Forms.LinkLabel();
            this.llWatchlist = new System.Windows.Forms.LinkLabel();
            this.llDepot = new System.Windows.Forms.LinkLabel();
            this.llFirstStep = new System.Windows.Forms.LinkLabel();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.pbNavigationChange = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNavigationChange)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.Controls.Add(this.rtbContent);
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMain.Location = new System.Drawing.Point(284, 75);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(479, 600);
            this.pnlMain.TabIndex = 0;
            // 
            // rtbContent
            // 
            this.rtbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContent.BackColor = System.Drawing.SystemColors.Window;
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Location = new System.Drawing.Point(16, 11);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(447, 568);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitle.Controls.Add(this.tbSearch);
            this.pnlTitle.Controls.Add(this.lblHeadline);
            this.pnlTitle.Location = new System.Drawing.Point(16, 15);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(747, 53);
            this.pnlTitle.TabIndex = 1;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Gray;
            this.tbSearch.Location = new System.Drawing.Point(544, 12);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(180, 26);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.Text = "Suchen...";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.ForeColor = System.Drawing.Color.Blue;
            this.lblHeadline.Location = new System.Drawing.Point(0, 12);
            this.lblHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(435, 39);
            this.lblHeadline.TabIndex = 1;
            this.lblHeadline.Text = "Willkommen im Handbuch";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNavigation.Controls.Add(this.llVerrechungskonto);
            this.pnlNavigation.Controls.Add(this.llWatchlist);
            this.pnlNavigation.Controls.Add(this.llDepot);
            this.pnlNavigation.Controls.Add(this.llFirstStep);
            this.pnlNavigation.Location = new System.Drawing.Point(16, 75);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(260, 344);
            this.pnlNavigation.TabIndex = 2;
            // 
            // llVerrechungskonto
            // 
            this.llVerrechungskonto.AutoSize = true;
            this.llVerrechungskonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llVerrechungskonto.ForeColor = System.Drawing.Color.Blue;
            this.llVerrechungskonto.Location = new System.Drawing.Point(4, 168);
            this.llVerrechungskonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llVerrechungskonto.Name = "llVerrechungskonto";
            this.llVerrechungskonto.Size = new System.Drawing.Size(57, 25);
            this.llVerrechungskonto.TabIndex = 9;
            this.llVerrechungskonto.TabStop = true;
            this.llVerrechungskonto.Text = "Bank";
            this.llVerrechungskonto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llVerrechungskonto_LinkClicked);
            // 
            // llWatchlist
            // 
            this.llWatchlist.AutoSize = true;
            this.llWatchlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llWatchlist.ForeColor = System.Drawing.Color.Blue;
            this.llWatchlist.Location = new System.Drawing.Point(4, 120);
            this.llWatchlist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llWatchlist.Name = "llWatchlist";
            this.llWatchlist.Size = new System.Drawing.Size(92, 25);
            this.llWatchlist.TabIndex = 8;
            this.llWatchlist.TabStop = true;
            this.llWatchlist.Text = "Watchlist";
            this.llWatchlist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llWatchlist_LinkClicked);
            // 
            // llDepot
            // 
            this.llDepot.AutoSize = true;
            this.llDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDepot.ForeColor = System.Drawing.Color.Blue;
            this.llDepot.Location = new System.Drawing.Point(4, 70);
            this.llDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llDepot.Name = "llDepot";
            this.llDepot.Size = new System.Drawing.Size(64, 25);
            this.llDepot.TabIndex = 7;
            this.llDepot.TabStop = true;
            this.llDepot.Text = "Depot";
            this.llDepot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDepot_LinkClicked);
            // 
            // llFirstStep
            // 
            this.llFirstStep.AutoSize = true;
            this.llFirstStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llFirstStep.ForeColor = System.Drawing.Color.Blue;
            this.llFirstStep.Location = new System.Drawing.Point(4, 21);
            this.llFirstStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llFirstStep.Name = "llFirstStep";
            this.llFirstStep.Size = new System.Drawing.Size(128, 25);
            this.llFirstStep.TabIndex = 6;
            this.llFirstStep.TabStop = true;
            this.llFirstStep.Text = "Erste Schritte";
            this.llFirstStep.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFirstStep_LinkClicked);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPicture.Controls.Add(this.pbNavigationChange);
            this.pnlPicture.Location = new System.Drawing.Point(16, 437);
            this.pnlPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(260, 239);
            this.pnlPicture.TabIndex = 11;
            // 
            // pbNavigationChange
            // 
            this.pbNavigationChange.Location = new System.Drawing.Point(27, 24);
            this.pbNavigationChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbNavigationChange.Name = "pbNavigationChange";
            this.pbNavigationChange.Size = new System.Drawing.Size(195, 193);
            this.pbNavigationChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNavigationChange.TabIndex = 0;
            this.pbNavigationChange.TabStop = false;
            // 
            // FrmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 669);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(789, 675);
            this.Name = "FrmGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handbuch MoneyMaker";
            this.pnlMain.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNavigationChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.LinkLabel llVerrechungskonto;
        private System.Windows.Forms.LinkLabel llWatchlist;
        private System.Windows.Forms.LinkLabel llDepot;
        private System.Windows.Forms.LinkLabel llFirstStep;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox pbNavigationChange;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}

