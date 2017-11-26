using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyMaker.Models.Database;
using MoneyMaker.ViewModels;
using System.IO;
using MoneyMaker.Helpers;
using MoneyMaker.Libraries.Navigation;

namespace MoneyMaker.Views
{
    public partial class UserProfilesView : MoneyMakerView
    {

        private UserProfileModel model = new UserProfileModel();
        private UserProfile selectedItem = null;

        public UserProfilesView()
        {
            InitializeComponent();
            splitContainerMain.Panel2Collapsed = true;
            refreshListAsync();
            mainForm.setHeadline("Benutzerprofile");           
        }

        private async void refreshListAsync()
        {
            if(mainForm.ManagerProfile != null)
            {

                mainForm.notifyUser(FrmMain.NotifyType.PrepareMessage, "Benutzerdaten werden geladen...");
            
                Task<IQueryable<UserProfile>> task = Task.Run(() => model.getItems(mainForm.ManagerProfile.AccountID));
                var collection = await task;

                lvUserList.Items.Clear();
                if(collection != null)
                {
                    foreach (var item in collection)
                    { 
                        string[] user = { item.ForName, item.LastName, item.Street+" "+item.StreetNumber, item.Postcode+" "+item.Town, item.PhoneNumber };
                        var lvItem = new ListViewItem(user);
                        lvItem.Tag = item;
                        lvUserList.Items.Add(lvItem);
                    }
                }
                mainForm.notifyUser(FrmMain.NotifyType.StatusMessage, "Bereit");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = false;
            splitContainerTop.Panel1Collapsed = true;
            btnAdd.Visible = false;
            resetFields();
            selectedItem = null;
        }

        private void lvUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            splitContainerMain.Panel2Collapsed = false;
            if(lvUserList.SelectedItems.Count > 0)
                selectedItem = (UserProfile) lvUserList.SelectedItems[0].Tag;
            if(selectedItem != null)
            {
                tbStreet.Text = selectedItem.Street;
                tbForName.Text = selectedItem.ForName;
                tbLastName.Text = selectedItem.LastName;
                tbPostcode.Text = selectedItem.Postcode;
                tbPhoneNumber.Text = selectedItem.PhoneNumber;
                tbStreetnumber.Text = selectedItem.StreetNumber;
                tbTown.Text = selectedItem.Town;
                pbProfilePicture.Image = loadPicture(selectedItem.ProfilePicture?.ToArray());
                btnDelete.Enabled = true;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {

            var manager = mainForm.ManagerProfile;

            if (selectedItem != null)
            {
                selectedItem.ForName = tbForName.Text;
                selectedItem.LastName = tbLastName.Text;
                selectedItem.Street = tbStreet.Text;
                selectedItem.StreetNumber = tbStreetnumber.Text;
                selectedItem.Postcode = tbPostcode.Text;
                selectedItem.Town = tbTown.Text;
                selectedItem.PhoneNumber = tbPhoneNumber.Text;
                selectedItem.ProfilePicture = savePicture();
                model.updateItem(selectedItem);
            }
            else
            {
                if(manager != null && tbLastName.Text.Length > 0 && tbForName.Text.Length > 0 )
                {
                    model.createItem(new UserProfile() {
                        Street = tbStreet.Text,
                        ForName = tbForName.Text,
                        LastName = tbLastName.Text,
                        PhoneNumber = tbPhoneNumber.Text,
                        Postcode = tbPostcode.Text,
                        Town = tbTown.Text,
                        StreetNumber = tbStreetnumber.Text,
                        AccountID = manager.AccountID,
                        ProfilePicture = savePicture()                        
                    });
                }
                else
                {
                    MessageBox.Show("Bitte geben sie mindestens einen Vor- und Nachnamen für das Benutzerprofil ein.");
                }
            }
            
            bool selectFirstUser = (mainForm.User == null) ? true : false;
            closeRightForm();
            mainForm.createUserSelectBoxAsync(selectFirstUser);
            
            refreshListAsync();
        }

        private void closeRightForm()
        {
            btnAdd.Visible = true;
            splitContainerMain.Panel2Collapsed = true;
            splitContainerTop.Panel1Collapsed = false;
            selectedItem = null;
        }

        private byte[] savePicture()
        {
            MemoryStream stream = new MemoryStream();

            pbProfilePicture.Image.Save(stream, pbProfilePicture.Image.RawFormat);

            byte[] pic = stream.ToArray();

            return pic;
        }

        private Bitmap loadPicture(byte[] profilePicture)
        {
            if (profilePicture != null)
            {
                MemoryStream stream = new MemoryStream();

                byte[] pic = profilePicture;

                stream.Write(pic, 0, Convert.ToInt32(pic.Length));

                Bitmap bm = new Bitmap(stream, false);

                stream.Dispose();
                
                return bm;
            }
            else
            {
                return Properties.Resources.UserProfilesIcon;
            }
            
        }

        private void resetFields()
        {
            tbStreet.Text = "";
            tbForName.Text = "";
            tbLastName.Text = "";
            tbStreet.Text = "";
            tbStreetnumber.Text = "";
            tbPostcode.Text = "";
            tbTown.Text = "";
            tbPhoneNumber.Text = "";
        }

        private void textBox_Enter(object sender, EventArgs e)
        {               
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeRightForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            if (selectedItem != null && lvUserList.Items.Count > 0)
            {
                model.deleteItem(selectedItem);                
                lvUserList.SelectedItems[0].Remove();
                if (lvUserList.Items.Count == 0)
                    btnDelete.Enabled = false;
                mainForm.createUserSelectBoxAsync(false);
            }            
            closeRightForm();
        }
        
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofDialog.Filter = "Bilddateien (*.gif,*.jpg,*.jpeg,*.bmp,*.wmf,*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {                
                pbProfilePicture.Image = Image.FromStream(ofDialog.OpenFile());
            }
        }

        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            selectedItem.ProfilePicture = null;
            pbProfilePicture.Image = loadPicture(selectedItem.ProfilePicture?.ToArray());
        }
        /// <summary>
        /// Methods to prevent wrong user input
        /// </summary>
        private void checkKeyPressDigit(object sender, KeyPressEventArgs e)
        {
            MoneyMakerHelper.textboxCheckDigital(ref sender, ref e);
        }

        private void checkKeyPressLetter(object sender, KeyPressEventArgs e)
        {
            MoneyMakerHelper.textboxCheckLetter(ref sender, ref e);
        }

        private void lvUserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Point mousePos = lvUserList.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = lvUserList.HitTest(mousePos);

            var selectedUser = hitTest.Item;
            if (selectedUser?.Tag != null)
            {
                var selectedUserTag = (UserProfile)selectedUser.Tag;
                mainForm.setUser(selectedUserTag);
            }
        }
    }
}

