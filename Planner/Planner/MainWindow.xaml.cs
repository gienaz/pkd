using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Planner
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] DayButtons;
        public int currentDay;
        public int currentMonth;
        public int currentYear;
        public int daysInMonth;
        public string firstDayOfMonth;

        public MainWindow()
        {
            InitializeComponent();

            InitializeCalendar();
            RefreshCalendar();
        }

        void InitializeCalendar()
        {
            currentDay= Convert.ToInt32(DateTime.Now.ToString("dd"));
            currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            currentYear = DateTime.Now.Year;

            DayButtons = new Button[7,7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; i < 7; i++)
                {
                    DayButtons[i, j] = (Button)CalendarGrid.FindName("btn_" + GetDayOfMonth(i) + "_" + j);
                }
            }
        }

        void RefreshCalendar()
        {
            daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            firstDayOfMonth = new DateTime(currentYear, currentMonth, 1).ToString("ddd");
            txt_Month.Content = GetMonthFull(currentMonth);
            txt_Year.Content = currentYear.ToString() + " г.";
            countingDays = 1;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; i < 7; i++)
                {
                    DayButtons[i, j].Content = SetDaysInMonth(i, j);
                }
            }

        }


            int countingDays = 1;
        int SetDaysInMonth(int i, int j)
        {
            DateTime dateFirst = new DateTime(currentYear, currentMonth, 1);
            int firstDayOfWeek = (int)dateFirst.DayOfWeek;
            dateFirst = new DateTime(currentYear, currentMonth, daysInMonth);
            int lastDayOfWeek = (int)dateFirst.DayOfWeek;


            if ( j == 0 && i < firstDayOfWeek)
            {
                return 0;
            }
            else if( j == 7 && i > lastDayOfWeek)
            {
                return 0;
            }
            else
            {
                countingDays++;
                return countingDays - 1;
            }

        }
        string GetDayOfMonth(int d)
        {
            if (d == 0) { return "Mon"; }
            else if (d == 1) { return "Tue"; }
            else if (d == 2) { return "Wed"; }
            else if (d == 3) { return "Thu"; }
            else if (d == 4) { return "Fri"; }
            else if (d == 5) { return "Sat"; }
            else if (d == 6) { return "Sun"; }
            else {
                return "";
            } 
        }
        string GetMonthFull(int m)
        {

            string fullMonthName = new DateTime(2005, m, 1).ToString("MMMM");

            return fullMonthName;
        }

        private void btn_NextMonth_Click(object sender, RoutedEventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12) { currentMonth = 1; currentYear++; }
            RefreshCalendar();
        }

        private void btn_PrevMonth_Click(object sender, RoutedEventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1) { currentMonth = 12; currentYear--; }
            RefreshCalendar();
        }

    }
}
