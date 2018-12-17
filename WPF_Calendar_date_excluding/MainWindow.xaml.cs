using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calendar_date_excluding
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dates = new List<DateTime>();
        }

        private static List<DateTime> Dates;

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;

            if (picker != null)
            {
                DateTime? date = picker.SelectedDate;
                if (date == null)
                {
                    this.Title = "No date";
                }
                else
                {
                    this.Title = date.Value.ToShortDateString();
                }
            }
        }

        private void SetDisplayDates()
        {
            //MonthlyCalendar.DisplayDate = new DateTime(2018, 3, 5);
            //MonthlyCalendar.DisplayDateStart = new DateTime(2018, 3, 1);
            //MonthlyCalendar.DisplayDateEnd = new DateTime(2018, 3, 31);
        }

        private List<DateTime> AddDefault()
        {
            List<DateTime> defaultDateTimes = new List<DateTime>();
            defaultDateTimes.Add(new DateTime(2018, 12, 5));
            defaultDateTimes.Add(new DateTime(2018, 12, 7));
            defaultDateTimes.Add(new DateTime(2018, 12, 9));
            defaultDateTimes.Add(new DateTime(2018, 12, 11));
            defaultDateTimes.Add(new DateTime(2018, 12, 13));
            defaultDateTimes.Add(new DateTime(2018, 12, 15));
            defaultDateTimes.Add(new DateTime(2018, 12, 17));
            defaultDateTimes.Add(new DateTime(2018, 12, 19));
            defaultDateTimes.Add(new DateTime(2018, 12, 21));
            defaultDateTimes.Add(new DateTime(2018, 12, 23));

            return defaultDateTimes;
        }

        private void AddDate(DateTime start, DateTime end)
        {

        }

        private void AddDate(DateTime oneDay)
        {

        }

        private void Btn_LoadDefaultData_Click(object sender, RoutedEventArgs e)
        {
            foreach (DateTime dateTime in AddDefault())
            {
                if(check(dateTime))
                calendar.BlackoutDates.Add(new CalendarDateRange(dateTime));
            }

            
        }

        private bool check(DateTime newDateTime)
        {
            foreach (DateTime saveDateTime in Dates)
            {
                if (newDateTime == saveDateTime)
                {

                    return false;
                }
            }
            Dates.Add(newDateTime);
            return true;
        }

        private void Btn__AddDate_Click(object sender, RoutedEventArgs e)
        {
            //check
            ////      calendar.

            ////      this.pick_endDate
            ////      this.pick_startDate

            calendar.BlackoutDates.Add(new CalendarDateRange((DateTime) pick_endDate.SelectedDate, (DateTime) pick_startDate.SelectedDate));
        }
    }
}
