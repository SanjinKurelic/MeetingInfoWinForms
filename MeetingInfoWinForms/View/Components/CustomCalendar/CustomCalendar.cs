using System;
using System.Windows.Forms;
using MeetingInfoWinForms.Model;

namespace MeetingInfoWinForms
{
    public partial class CustomCalendar : UserControl
    {

        private SelectedDateVM selectedDate;

        public CustomCalendar()
        {
            InitializeComponent();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(selectedDate.CurrentDate == calendar.SelectionStart)
            {
                return;
            }
            selectedDate.CurrentDate = calendar.SelectionStart;
        }

        private void SelectWeek()
        {
            DateTime selectedDate = calendar.SelectionStart;
            DateTime firstDay = selectedDate.AddDays(DayOfWeek.Monday - selectedDate.DayOfWeek);
            calendar.SelectionStart = firstDay;
            calendar.SelectionEnd = firstDay.AddDays(6);
        }

        public void DateChanged(object sender, EventArgs eventArgs)
        {
            calendar.SelectionStart = ((SelectedDateVM)sender).CurrentDate;
            SelectWeek();
        }

        private void CustomCalendar_Load(object sender, EventArgs e)
        {
            selectedDate = SelectedDateService.GetSelectedDateVM();
            SelectWeek();
        }
    }
}
