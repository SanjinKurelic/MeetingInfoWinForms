using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingInfoWinForms.Model
{
    class SelectedDateService
    {

        private static SelectedDateVM selectedDateVM;

        public static SelectedDateVM GetSelectedDateVM()
        {
            if (selectedDateVM == null)
            {
                selectedDateVM = new SelectedDateVM(new SelectedDate()
                {
                    CurrentDate = DateTime.Now
                });
            }
            return selectedDateVM;
        }

    }
}
