using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ManPowerManagement.Infrastructure
{
    public static class Utility
    {
        public const string MESSAGE_TITLE = "Man Power Management";
        public const string VALIDITY_MSG = "Please Enter Valid Data";
        public const string INSERT_MSG = "Data added successfully";
        public const string UPDATE_MSG = "Data updated successfully";
        public const string DELETE_MSG = "Data deleted successfully";
        public const string NO_DATA_FOUND_MSG = "No Data Found";
        public const string DELETE_CONFIRMATION_MSG = "Do you really want to delete this data?";
        public const string VALID_NUMERIC_DATA_MSG = "Please Enter Numeric Data";
        public const string MULTIPLE_ENTRY_MSG = "Cann't be inserted For Duplicate Entry againest same ID.";
        public const string PREVIEW_WITHOUT_SOME_DATA = "Do you want to continue without some data?";

        public static string GetDateFormatSting()
        {
            return "dd/MM/yyyy";
        }

        public static void ClearControl(Control aControl)
        {
            Form mForm;
            TextBox mTextBox;
            CheckBox mCheckBox;
            RadioButton mRadioButton;
            //Control mControl;
            GroupBox mGroupBox;
            DateTimePicker mDateTimePicker;
            ComboBox mComboBox;
            TabControl mTabControl;
            TabPage mTabPage;
            if (aControl is Form)
            {
                mForm = (Form) aControl;
                mForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                mForm.BackColor = Color.FromArgb(208, 214, 223);
                foreach (var control in mForm.Controls)
                {
                    ClearControl(control as Control);
                }
            }else if (aControl is TextBox)
            {
                mTextBox = (TextBox) aControl;
                mTextBox.Clear();
            }else if (aControl is DateTimePicker)
            {
                mDateTimePicker = (DateTimePicker) aControl;
                mDateTimePicker.Value = DateTime.Now;
            }else if (aControl is ComboBox)
            {
                mComboBox = (ComboBox) aControl;
                if (mComboBox.DropDownStyle != ComboBoxStyle.DropDownList)
                {
                    mComboBox.Text = "";
                }
                mComboBox.SelectedIndex = -1;
            }
            else if (aControl is CheckBox)
            {
                mCheckBox = (CheckBox)aControl;
                mCheckBox.Checked = false;
            }else if (aControl is RadioButton)
            {
                mRadioButton = (RadioButton)aControl;
                mRadioButton.Checked = false;
            }else if (aControl is GroupBox)
            {
                mGroupBox = (GroupBox)aControl;
                foreach (var control in mGroupBox.Controls)
                {
                    ClearControl(control as Control);
                }
            }else if (aControl is TabControl)
            {
                mTabControl = (TabControl)aControl;
                for (int i = 0; i < mTabControl.TabPages.Count; i++)
                {
                    ClearControl(mTabControl.TabPages[i]);
                }
            }else if (aControl is TabPage)
            {
                mTabPage = (TabPage)aControl;
                foreach (var control in mTabPage.Controls)
                {
                    ClearControl(control as Control);
                }
            }

        }

        public static void ShowNotice(String Message, String Notice = MESSAGE_TITLE)
        {
            MessageBox.Show(Message, Notice, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        public static void ShowError(String Message, String Notice = MESSAGE_TITLE + ": Error in Operation")
        {
            MessageBox.Show(Message, Notice, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
        }

        public static void ShowMessage(String Message, String Notice = MESSAGE_TITLE)
        {
            MessageBox.Show(Message, Notice, MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        public static bool ShowConfirmationMessage(String ConfirmationMessage = DELETE_CONFIRMATION_MSG)
        {
            DialogResult result = MessageBox.Show(ConfirmationMessage, "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else if (result == DialogResult.No)
            {
                return false;
            }
            else if (result == DialogResult.Cancel)
            {
               
            }
            return false;
        }

        public static void DisplayListData(ListBox aListBox, Object Data, string DisplayMember, string ValueMember)
        {
            try
            {
                aListBox.BeginUpdate();
                aListBox.DataSource = null;
                aListBox.Items.Clear();
                aListBox.DisplayMember = DisplayMember;
                aListBox.ValueMember = ValueMember;
                aListBox.DataSource = Data;
                aListBox.EndUpdate();
            }
            catch (Exception e)
            {
                Utility.ShowMessage(e.Message);
            }

        }

        public static void DisplayCheckListData(CheckedListBox aCheckListBox, Object Data, string DisplayMember,
            string ValueMember)
        {
            try
            {
                aCheckListBox.BeginUpdate();
                aCheckListBox.DataSource = null;
                aCheckListBox.Items.Clear();
                aCheckListBox.DisplayMember = DisplayMember;
                aCheckListBox.ValueMember = ValueMember;
                aCheckListBox.DataSource = Data;
                aCheckListBox.EndUpdate();
            }
            catch (Exception e)
            {
                ShowError(e.Message);
            }
        }

        public static void DisplayComboData(ComboBox aComboBox, Object Data, string DisplayMember, string ValueMember)
        {
            try
            {
                aComboBox.BeginUpdate();
                aComboBox.DataSource = null;
                aComboBox.DisplayMember = DisplayMember;
                aComboBox.ValueMember = ValueMember;
                aComboBox.DataSource = Data;
                aComboBox.EndUpdate();
            }
            catch (Exception e)
            {
                ShowError(e.Message);
            }
        }

        public static byte[] ImageDataToByte(string path)
        {
            byte[] image = new byte[] { };
            if (string.IsNullOrEmpty(path))
            {
                return image;
            }
            else
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryReader reader = new BinaryReader(fs);
                image = reader.ReadBytes((int) fs.Length);
                fs.Close();
                return image;
            }
        }

        public static byte[] ImageDataToByte(Image aImage)
        {
            byte[] image = new byte[] { };
            if (aImage == null)
            {
                return image;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                aImage.Save(ms,ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image ByteDataToImage(byte[] ByteData)
        {
            Image newImage = null;
            if (ByteData.Length > 1)
            {
                MemoryStream stream = new MemoryStream(ByteData);
                newImage = Image.FromStream(stream);
            }
            return newImage;
        }
    }
}
