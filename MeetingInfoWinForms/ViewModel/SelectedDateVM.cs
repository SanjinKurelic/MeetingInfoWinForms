using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingInfoWinForms.Model
{
    class SelectedDateVM : INotifyPropertyChanged
    {

        private SelectedDate selectedDate;
        public event PropertyChangedEventHandler PropertyChanged;

        public SelectedDateVM(SelectedDate selectedDate)
        {
            this.selectedDate = selectedDate;
        }

        public DateTime CurrentDate {
            get { return selectedDate.CurrentDate; }
            set {
                selectedDate.CurrentDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date changed")); //MLHIDE
            }
        }

    }
}
