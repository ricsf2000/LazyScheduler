using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LazyScheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double hours;
        private double minutes;
        public int TotalDifficulty;
        ObservableCollection<Assignment> assignmentList = new ObservableCollection<Assignment>();
        public ObservableCollection<Assignment> AssignmentList;
        
        public MainWindow()
        {
            InitializeComponent();
            TotalDifficulty = 0;
        }

        private void Calendar_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is Calendar calendar)
            {
                var calendarItem = calendar.Template.FindName("PART_CalendarItem", calendar) as CalendarItem;
                if (calendarItem != null)
                {
                    foreach (var dayButton in calendarItem.FindVisualChildren<CalendarDayButton>())
                    {
                        dayButton.PreviewMouseDown += DayButton_PreviewMouseDown;
                    }
                }
            }
        }

        private void DayButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CalendarDayButton dayButton = sender as CalendarDayButton;
            DateTime selectedDate = (DateTime)dayButton.DataContext;
            // Perform actions based on the selected date
            if (int.TryParse(Hours.Text, out int HoursOut) && int.TryParse(Minutes.Text, out int MinutesOut))
            {
                hours = HoursOut;
                minutes = MinutesOut;
            }
            else
            {
                MessageBox.Show("Invalid input.");
            }

        }
        private void GotFocus_General(TextBox Time, string timeType)
        {
            if (Time != null)
            {
                if (Time.Text == timeType)
                {
                    Time.Text = string.Empty;
                    Time.Foreground = System.Windows.Media.Brushes.Black;
                    Time.FontFamily = new System.Windows.Media.FontFamily("Bookman Old Style");
                    Time.FontStyle = FontStyles.Normal;
                }
            }
        }
        private void LostFocus_General(TextBox Time, string timeType)
        {
            if (Time != null)
            {
                if (Time.Text == "")
                {
                    Time.Text = timeType;
                    Time.Foreground = System.Windows.Media.Brushes.Gray; ;
                    Time.FontFamily = new System.Windows.Media.FontFamily("Segoe UI");
                    Time.FontStyle = FontStyles.Italic;
                }
            }
        }

        private void Hours_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocus_General(Hours, "Hours");
        }

        private void Hours_LostFocus(object sender, RoutedEventArgs e)
        {
            LostFocus_General(Hours, "Hours");
        }

        private void Minutes_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocus_General(Minutes, "Minutes");
        }

        private void Minutes_LostFocus(object sender, RoutedEventArgs e)
        {
            LostFocus_General(Minutes, "Minutes");
        }

        //private void tasksListView(object sender, RoutedEventArgs e)

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Close();
        }
    }
}