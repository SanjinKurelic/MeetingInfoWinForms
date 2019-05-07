using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MeetingInfoWinForms.Model;
using System.Diagnostics;
using MeetingInfoDatabase.Models;
using System.Resources;
using System.Threading;

namespace MeetingInfoWinForms
{
    public partial class WeekPlaner : UserControl
    {

        #region Constants
        private const int ELEMENT_PADDING_LEFT = 1;
        private const int ELEMENT_PADDING_TOP = 2;
        private const int ELEMENT_PADDING_RIGHT = 0;
        private const int ELEMENT_PADDING_BOTTOM = 0;

        private const string ELEMENT_TITLE_FONT = "Roboto";           //MLHIDE
        private const int ELEMENT_TITLE_FONT_SIZE = 9;
        private const int ELEMENT_TITLE_HEIGHT = 18;

        private const string ELEMENT_DESCRIPTION_FONT = "Roboto";     //MLHIDE
        private const int ELEMENT_DESCRIPTION_FONT_SIZE = 7;
        private const int ELEMENT_DESCRIPTION_HEIGHT = 16;

        private const int HOUR_PADDING = 8;
        private const int DAY_PADDING = 1;
        #endregion

        private Dictionary<int, Meeting> currentMeetings;

        private const string LOCALIZATION_KEY = ".Text";

        public WeekPlaner()
        {
            InitializeComponent();
            Translate();
        }

        private void Translate()
        {
            ResourceManager rm = new ResourceManager("MeetingInfoWinForms.WeekPlaner", System.Reflection.Assembly.GetExecutingAssembly());
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            lbHour.Text = rm.GetString(nameof(lbHour) + LOCALIZATION_KEY);
            lbMon.Text = rm.GetString(nameof(lbMon) + LOCALIZATION_KEY);
            lbTuesday.Text = rm.GetString(nameof(lbTuesday) + LOCALIZATION_KEY);
            lbWednesday.Text = rm.GetString(nameof(lbWednesday) + LOCALIZATION_KEY);
            lbThursday.Text = rm.GetString(nameof(lbThursday) + LOCALIZATION_KEY);
            lbFriday.Text = rm.GetString(nameof(lbFriday) + LOCALIZATION_KEY);

            deleteToolStripMenuItem.Text = rm.GetString(nameof(deleteToolStripMenuItem) + LOCALIZATION_KEY);
            editToolStripMenuItem.Text = rm.GetString(nameof(editToolStripMenuItem) + LOCALIZATION_KEY);
        }

        private Color GetColor(DateTime date)
        {
            string error = "Date '" + date + "' is not valid. Meetings can not be on "; //MLHIDE
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return Color.FromArgb(255, 136, 0);
                case DayOfWeek.Tuesday:
                    return Color.Tan;
                case DayOfWeek.Wednesday:
                    return Color.FromArgb(246, 187, 66);
                case DayOfWeek.Thursday:
                    return Color.FromArgb(140, 193, 82);
                case DayOfWeek.Friday:
                    return Color.FromArgb(150, 122, 220);
                case DayOfWeek.Sunday:
                    error += "Sunday.";                               //MLHIDE
                    break;
                case DayOfWeek.Saturday:
                    error += "Saturday.";                             //MLHIDE
                    break;
                default:
                    error += "Unknown day.";                          //MLHIDE
                    break;
            }
            throw new ArgumentException(error);
        }

        private FlowLayoutPanel GetPanel(Meeting meeting)
        {
            // Panel settings
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.BackColor = GetColor(meeting.Date);
            panel.Margin = Padding.Empty;
            panel.Padding = new Padding(ELEMENT_PADDING_LEFT, ELEMENT_PADDING_TOP, ELEMENT_PADDING_RIGHT, ELEMENT_PADDING_BOTTOM);
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Enabled = true;
            panel.BringToFront();

            // Panel elements
            panel.Controls.Add(new Label()
            {
                Text = meeting.Title,
                Font = new Font(ELEMENT_TITLE_FONT, ELEMENT_TITLE_FONT_SIZE, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(panel.Width, ELEMENT_TITLE_HEIGHT)
            });
            panel.Controls.Add(new Label()
            {
                Text = meeting.Description,
                Font = new Font(ELEMENT_DESCRIPTION_FONT, ELEMENT_DESCRIPTION_FONT_SIZE),
                AutoSize = false,
                Size = new Size(panel.Width, ELEMENT_DESCRIPTION_HEIGHT)
            });

            // Panel events & tooltip
            string toolTipText = meeting.Description + ". (" + meeting.Place + ")"; //MLHIDE
            panel.ContextMenuStrip = contextMenuMeeting;
            panel.DoubleClick += Meeting_Click;
            toolTipDescription.SetToolTip(panel, toolTipText);
            foreach (Control c in panel.Controls)
            {
                c.DoubleClick += Meeting_Click;
                toolTipDescription.SetToolTip(c, toolTipText);
            }

            // Panel data
            panel.Tag = meeting.IDMeeting;

            return panel;
        }

        private void AddToTable(Meeting meeting)
        {
            int day = (int)meeting.Date.DayOfWeek - DAY_PADDING;
            int hour = meeting.Date.TimeOfDay.Hours - HOUR_PADDING;
            try
            {
                meetingTable.Controls.Add(GetPanel(meeting), day, hour);
            }
            catch (ArgumentException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Meeting_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel selectedPanel;
            if (sender is Label)
            {
                selectedPanel = (sender as Label).Parent as FlowLayoutPanel;
            }
            else
            {
                selectedPanel = sender as FlowLayoutPanel;
            }

            int meetingId = int.Parse(selectedPanel.Tag.ToString());
            MeetingInfo info = new MeetingInfo();
            info.Meeting = currentMeetings[meetingId];
            info.DisableInput();
            info.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menuStrip = (sender as ToolStripMenuItem).Owner as ContextMenuStrip;
            int meetingId = int.Parse((menuStrip.SourceControl as FlowLayoutPanel).Tag.ToString());

            MeetingInfo info = new MeetingInfo();
            info.Meeting = currentMeetings[meetingId];
            if (info.ShowDialog() == DialogResult.OK)
            {
                if (Program.Repository.GetMeetingsTable().ChangeMeeting(info.Meeting))
                {
                    MessageBox.Show(GlobalResources.SaveSuccess, GlobalResources.SuccessTitle, MessageBoxButtons.OK);
                    FillWeekPlaner(SelectedDateService.GetSelectedDateVM().CurrentDate);
                }
                else
                {
                    MessageBox.Show(GlobalResources.ErrorMessage, GlobalResources.ErrorTitle, MessageBoxButtons.OK);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menuStrip = (sender as ToolStripMenuItem).Owner as ContextMenuStrip;
            int meetingId = int.Parse((menuStrip.SourceControl as FlowLayoutPanel).Tag.ToString());

            if (MessageBox.Show(GlobalResources.DeleteConfirm, GlobalResources.ConfirmTitle, MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (Program.Repository.GetMeetingsTable().RemoveMeeting(meetingId))
                {
                    FillWeekPlaner(SelectedDateService.GetSelectedDateVM().CurrentDate);
                }
            }
        }

        public void ClearTable()
        {
            meetingTable.Controls.Clear();
        }

        public void FillWeekPlaner(DateTime date)
        {
            ClearTable();
            currentMeetings = new Dictionary<int, Meeting>();
            foreach (Meeting meeting in Program.Repository.GetMeetingsTable().GetMeetings(date))
            {
                currentMeetings.Add(meeting.IDMeeting, meeting);
                AddToTable(meeting);
            }
        }

    }
}
