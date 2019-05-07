using System;
using System.Windows.Forms;
using MeetingInfoDatabase.Models;

namespace MeetingInfoWinForms
{
    public partial class MeetingInfo : Form
    {

        private string CLOSE_BUTTON_TEXT = GlobalResources.CloseButton;
        public Meeting Meeting { get; set; }

        public MeetingInfo()
        {
            InitializeComponent();
            CenterToScreen();
            FillClients();
        }

        private void MeetingInfo_Load(object sender, EventArgs e)
        {
            if (Meeting != null)
            {
                FillForm();
            }
        }

        public void DisableInput()
        {
            foreach(Control control in meetingInfoTable.Controls)
            {
                if(control is TextBox || control is DateTimePicker || control is ComboBox)
                {
                    control.Enabled = false;
                }
            }
            btnClose.Visible = false;
            btnSave.Text = CLOSE_BUTTON_TEXT;
        }

        private void FillClients()
        {
            cbClients.DataSource = Program.Repository.GetClientTable().GetClients();
            cbClients.SelectedIndex = 0;
        }

        private void FillForm()
        {
            tbDate.Value = Meeting.Date.Date;
            try
            {
                tbTime.Value = new DateTime(1753, 1, 1).AddTicks(Meeting.Date.TimeOfDay.Ticks);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // if time stored in database is wrong
                tbTime.Value = tbTime.MinDate;
            }
            tbTitle.Text = Meeting.Title;
            tbDescription.Text = Meeting.Description;
            tbPlace.Text = Meeting.Place;
            foreach(object client in cbClients.Items)
            {
                if(((Client)client).IDClient == Meeting.ClientID)
                {
                    cbClients.SelectedItem = client;
                    break;
                }
            }
        }

        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client client = cbClients.SelectedItem as Client;
            tbClientName.Text = client.Name;
            tbClientSurname.Text = client.Surname;
            tbClientEmail.Text = client.Email;
            tbClientPhone.Text = client.Phone;
        }

        private bool IsDateReserved(DateTime dateTime)
        {
            foreach(Meeting meeting in Program.Repository.GetMeetingsTable().GetMeetings(dateTime))
            {
                if(dateTime == meeting.Date)
                {
                    // Same meeting
                    if (Meeting != null && Meeting.IDMeeting == meeting.IDMeeting)
                    {
                        continue;
                    }
                    return true;
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if(string.IsNullOrWhiteSpace(tbTitle.Text) || string.IsNullOrWhiteSpace(tbDescription.Text) || string.IsNullOrWhiteSpace(tbPlace.Text))
            {
                MessageBox.Show(GlobalResources.RequiredMessage, GlobalResources.ErrorTitle, MessageBoxButtons.OK);
                return;
            }            
            DateTime meetingDate = new DateTime(tbDate.Value.Year, tbDate.Value.Month, tbDate.Value.Day, tbTime.Value.Hour, 0, 0);
            if(IsDateReserved(meetingDate))
            {
                MessageBox.Show(GlobalResources.DateReserved, GlobalResources.ErrorTitle, MessageBoxButtons.OK);
                return;
            }
            // Logic
            if (Meeting == null)
            {
                Meeting = new Meeting();
            }
            Meeting.Date = meetingDate;
            Meeting.Title = tbTitle.Text;
            Meeting.Description = tbDescription.Text;
            Meeting.Place = tbPlace.Text;
            Meeting.ClientID = (cbClients.SelectedItem as Client).IDClient;
            // Set result of dialog to OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
