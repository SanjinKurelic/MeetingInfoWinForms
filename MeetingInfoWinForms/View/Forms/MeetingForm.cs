using MeetingInfoWinForms.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Collections.Generic;

namespace MeetingInfoWinForms
{
    public partial class MeetingForm : Form
    {

        #region Constants
        private string INSERT_SUCCESSFULLY = GlobalResources.SaveSuccess;
        private string INSERTED_SUCCESSFULLY_TITLE = GlobalResources.SuccessTitle;
        private string ERROR_MESSAGE = GlobalResources.ErrorMessage;
        private string ERROR_MESSAGE_TITLE = GlobalResources.ErrorTitle;
        #endregion

        private CultureInfo currentLanguage;
        private List<CultureInfo> languagesList;

        public event EventHandler LanguageChanged;
        private SelectedDateVM selectedDate;

        public MeetingForm()
        {
            InitializeComponent();
            CenterToScreen();

            currentLanguage = Thread.CurrentThread.CurrentCulture;
            languagesList = new List<CultureInfo>();
            languagesList.Add(new CultureInfo("en-US"));
            languagesList.Add(new CultureInfo("hr"));
        }

        private void MeetingForm_Load(object sender, EventArgs e)
        {
            selectedDate = SelectedDateService.GetSelectedDateVM();
            selectedDate.PropertyChanged += weekSelector.DateChanged;
            selectedDate.PropertyChanged += yearPicker_SetValue;
            selectedDate.PropertyChanged += monthPicker_SetValue;
            selectedDate.PropertyChanged += SelectedDate_PropertyChanged;
            selectedDate.CurrentDate = DateTime.Now;
        }

        private void SelectedDate_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            FillWeekPlaner();
        }

        /**
         * Fixing issues with 31.1 => +1 month => 31.2 (bug in datepicker)
         * */
        private DateTime GetDateTime(int year, int month)
        {
            DateTime dateTime = new DateTime(year, month, 1);
            int daysToAdd = ((int)DayOfWeek.Monday - (int)dateTime.DayOfWeek + 7) % 7;
            return dateTime.AddDays(daysToAdd);
        }

        private void yearPicker_ValueChanged(object sender, EventArgs e)
        {
            if (yearPicker.Value.Year == selectedDate.CurrentDate.Year)
            {
                return;
            }
            selectedDate.CurrentDate = GetDateTime(yearPicker.Value.Year, selectedDate.CurrentDate.Month);
        }

        private void monthPicker_ValueChanged(object sender, EventArgs e)
        {
            if (monthPicker.Value.Month == selectedDate.CurrentDate.Month)
            {
                return;
            }
            selectedDate.CurrentDate = GetDateTime(selectedDate.CurrentDate.Year, monthPicker.Value.Month);
        }

        private void yearPicker_SetValue(object sender, EventArgs e)
        {
            yearPicker.Value = GetDateTime(selectedDate.CurrentDate.Year, selectedDate.CurrentDate.Month);
        }

        private void monthPicker_SetValue(object sender, EventArgs e)
        {
            monthPicker.Value = GetDateTime(selectedDate.CurrentDate.Year, selectedDate.CurrentDate.Month);
        }

        private void FillWeekPlaner()
        {
            weekPlaner.FillWeekPlaner(selectedDate.CurrentDate);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MeetingInfo info = new MeetingInfo();
            if (info.ShowDialog() == DialogResult.OK)
            {
                if (Program.Repository.GetMeetingsTable().AddMeeting(info.Meeting))
                {
                    MessageBox.Show(INSERT_SUCCESSFULLY, INSERTED_SUCCESSFULLY_TITLE, MessageBoxButtons.OK);
                    FillWeekPlaner();
                }
                else
                {
                    MessageBox.Show(ERROR_MESSAGE, ERROR_MESSAGE_TITLE, MessageBoxButtons.OK);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printPlaner.DefaultPageSettings.Landscape = true;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printPlaner_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap output = new Bitmap(e.MarginBounds.Width, e.MarginBounds.Height, e.Graphics);
            weekPlaner.DrawToBitmap(output, new Rectangle(0, 0, output.Width, output.Height));
            e.Graphics.DrawImage(output, e.MarginBounds);

        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            currentLanguage = languagesList.SingleOrDefault(lang => lang.TwoLetterISOLanguageName != currentLanguage.TwoLetterISOLanguageName);
            Thread.CurrentThread.CurrentCulture = currentLanguage;
            Thread.CurrentThread.CurrentUICulture = currentLanguage;
            LanguageChanged?.Invoke(this, new PropertyChangedEventArgs("Language changed")); //MLHIDE
        }
    }
}