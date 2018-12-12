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
        private static DataTable dates;


        public MainWindow()
        {
            InitializeComponent();
            Dates = Dates = new DataTable();
        }

        public static DataTable Dates { get => dates; set => dates = value; }

        private void DatePicker_SelectedDateChanged(object sender,
            SelectionChangedEventArgs e)
        {
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                this.Title = date.Value.ToShortDateString();
            }
        }

        private void SetDisplayDates()
        {
            //MonthlyCalendar.DisplayDate = new DateTime(2018, 3, 5);
            //MonthlyCalendar.DisplayDateStart = new DateTime(2018, 3, 1);
            //MonthlyCalendar.DisplayDateEnd = new DateTime(2018, 3, 31);
        }
    }
}
