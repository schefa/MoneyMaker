namespace MoneyMaker.Views
{
    partial class UserProfilesView
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvUserList = new System.Windows.Forms.ListView();
            this.forName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.town = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbPostcode = new System.Windows.Forms.MaskedTextBox();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblPostcodeCity = new System.Windows.Forms.Label();
            this.tbStreetnumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbForName = new System.Windows.Forms.TextBox();
            this.userTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerTop);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.AutoScroll = true;
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainerMain.Panel2.Controls.Add(this.gbDetails);
            this.splitContainerMain.Panel2MinSize = 160;
            this.splitContainerMain.Size = new System.Drawing.Size(853, 480);
            this.splitContainerMain.SplitterDistance = 472;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 0;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainerTop.Name = "splitContainerTop";
            this.splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.panelTop);
            this.splitContainerTop.Panel1MinSize = 40;
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.lvUserList);
            this.splitContainerTop.Size = new System.Drawing.Size(472, 480);
            this.splitContainerTop.SplitterDistance = 40;
            this.splitContainerTop.SplitterWidth = 3;
            this.splitContainerTop.TabIndex = 5;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Window;
            this.panelTop.Controls.Add(this.btnDelete);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(472, 40);
            this.panelTop.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(119, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Löschen";
            this.userTooltip.SetToolTip(this.btnDelete, "Löscht den ausgewählten Benutzer in der Liste");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 27);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Hinzufügen";
            this.userTooltip.SetToolTip(this.btnAdd, "Öffnet im rechten Bereich ein neues Formular, wo Sie einen neuen Benutzer einpfle" +
        "gen können");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvUserList
            // 
            this.lvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.forName,
            this.lastName,
            this.street,
            this.town,
            this.phoneNumber});
            this.lvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUserList.FullRowSelect = true;
            this.lvUserList.Location = new System.Drawing.Point(0, 0);
            this.lvUserList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lvUserList.MultiSelect = false;
            this.lvUserList.Name = "lvUserList";
            this.lvUserList.Size = new System.Drawing.Size(472, 437);
            this.lvUserList.TabIndex = 2;
            this.lvUserList.UseCompatibleStateImageBehavior = false;
            this.lvUserList.View = System.Windows.Forms.View.Details;
            this.lvUserList.SelectedIndexChanged += new System.EventHandler(this.lvUserList_SelectedIndexChanged);
            this.lvUserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvUserList_MouseDoubleClick);
            // 
            // forName
            // 
            this.forName.Text = "Vorname";
            this.forName.Width = 87;
            // 
            // lastName
            // 
            this.lastName.Text = "Nachname";
            this.lastName.Width = 134;
            // 
            // street
            // 
            this.street.Text = "Straße";
            this.street.Width = 203;
            // 
            // town
            // 
            this.town.Text = "Ort";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Telefonnummer";
            this.phoneNumber.Width = 141;
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.Controls.Add(this.tbPostcode);
            this.gbDetails.Controls.Add(this.btnDeletePicture);
            this.gbDetails.Controls.Add(this.btnClose);
            this.gbDetails.Controls.Add(this.tbPhoneNumber);
            this.gbDetails.Controls.Add(this.btnAddPicture);
            this.gbDetails.Controls.Add(this.tbTown);
            this.gbDetails.Controls.Add(this.panel1);
            this.gbDetails.Controls.Add(this.lblPostcodeCity);
            this.gbDetails.Controls.Add(this.tbStreetnumber);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Controls.Add(this.btnSave);
            this.gbDetails.Controls.Add(this.lblStreetNumber);
            this.gbDetails.Controls.Add(this.tbStreet);
            this.gbDetails.Controls.Add(this.tbLastName);
            this.gbDetails.Controls.Add(this.lblPhoneNumber);
            this.gbDetails.Controls.Add(this.tbForName);
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(14, 14);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(5);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(5);
            this.gbDetails.Size = new System.Drawing.Size(331, 448);
            this.gbDetails.TabIndex = 15;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Benutzerbeschreibung";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(13, 164);
            this.tbPostcode.Mask = "00000";
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(89, 25);
            this.tbPostcode.TabIndex = 11;
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePicture.Location = new System.Drawing.Point(157, 321);
            this.btnDeletePicture.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.Size = new System.Drawing.Size(155, 40);
            this.btnDeletePicture.TabIndex = 15;
            this.btnDeletePicture.Text = "Bild löschen";
            this.btnDeletePicture.UseVisualStyleBackColor = true;
            this.btnDeletePicture.Click += new System.EventHandler(this.btnDeletePicture_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(208, 392);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 35);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Schließen";
            this.userTooltip.SetToolTip(this.btnClose, "Schließt das geöffnete Formular wieder");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(12, 218);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(305, 25);
            this.tbPhoneNumber.TabIndex = 13;
            this.tbPhoneNumber.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkKeyPressDigit);
            this.tbPhoneNumber.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPicture.Location = new System.Drawing.Point(157, 272);
            this.btnAddPicture.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(155, 40);
            this.btnAddPicture.TabIndex = 14;
            this.btnAddPicture.Text = "Bild ändern";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // tbTown
            // 
            this.tbTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTown.Location = new System.Drawing.Point(110, 164);
            this.tbTown.Margin = new System.Windows.Forms.Padding(5);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(207, 25);
            this.tbTown.TabIndex = 12;
            this.tbTown.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbTown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkKeyPressLetter);
            this.tbTown.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbProfilePicture);
            this.panel1.Location = new System.Drawing.Point(12, 264);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 103);
            this.panel1.TabIndex = 2;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Image = global::MoneyMaker.Properties.Resources.UserProfilesIcon;
            this.pbProfilePicture.Location = new System.Drawing.Point(3, 5);
            this.pbProfilePicture.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(117, 89);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 1;
            this.pbProfilePicture.TabStop = false;
            // 
            // lblPostcodeCity
            // 
            this.lblPostcodeCity.AutoSize = true;
            this.lblPostcodeCity.Location = new System.Drawing.Point(9, 141);
            this.lblPostcodeCity.Name = "lblPostcodeCity";
            this.lblPostcodeCity.Size = new System.Drawing.Size(96, 19);
            this.lblPostcodeCity.TabIndex = 5;
            this.lblPostcodeCity.Text = "PLZ und Stadt";
            // 
            // tbStreetnumber
            // 
            this.tbStreetnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStreetnumber.Location = new System.Drawing.Point(249, 111);
            this.tbStreetnumber.Margin = new System.Windows.Forms.Padding(5);
            this.tbStreetnumber.MaxLength = 5;
            this.tbStreetnumber.Name = "tbStreetnumber";
            this.tbStreetnumber.Size = new System.Drawing.Size(68, 25);
            this.tbStreetnumber.TabIndex = 10;
            this.tbStreetnumber.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbStreetnumber.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Vor- Nachname";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(18, 392);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 35);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Speichern";
            this.userTooltip.SetToolTip(this.btnSave, "Speichern die eingegebenen Daten des Nutzerprofils");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Location = new System.Drawing.Point(8, 87);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(163, 19);
            this.lblStreetNumber.TabIndex = 4;
            this.lblStreetNumber.Text = "Straße und Hausnummer";
            // 
            // tbStreet
            // 
            this.tbStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStreet.Location = new System.Drawing.Point(12, 111);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(5);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(227, 25);
            this.tbStreet.TabIndex = 9;
            this.tbStreet.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkKeyPressLetter);
            this.tbStreet.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(157, 57);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(160, 25);
            this.tbLastName.TabIndex = 8;
            this.tbLastName.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkKeyPressLetter);
            this.tbLastName.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(9, 195);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Telefonnummer";
            // 
            // tbForName
            // 
            this.tbForName.Location = new System.Drawing.Point(12, 56);
            this.tbForName.Margin = new System.Windows.Forms.Padding(5);
            this.tbForName.Name = "tbForName";
            this.tbForName.Size = new System.Drawing.Size(135, 25);
            this.tbForName.TabIndex = 7;
            this.tbForName.Enter += new System.EventHandler(this.textBox_Enter);
            this.tbForName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkKeyPressLetter);
            this.tbForName.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // userTooltip
            // 
            this.userTooltip.AutoPopDelay = 5000;
            this.userTooltip.InitialDelay = 200;
            this.userTooltip.ReshowDelay = 100;
            // 
            // UserProfilesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "UserProfilesView";
            this.Size = new System.Drawing.Size(853, 480);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Label lblPostcodeCity;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbForName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainerTop;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvUserList;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbStreetnumber;
        private System.Windows.Forms.ColumnHeader town;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader forName;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.MaskedTextBox tbPostcode;
        private System.Windows.Forms.ToolTip userTooltip;
    }
}
