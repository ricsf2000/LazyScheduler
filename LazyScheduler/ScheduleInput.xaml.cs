using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace LazyScheduler
{
    /// <summary>
    /// Interaction logic for ScheduleInput.xaml
    /// </summary>
    public partial class ScheduleInput : Window
    {
        public ScheduleInput()
        {
            InitializeComponent();
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
            GotFocus_General(Hours, "Minutes");
        }

        private void Minutes_LostFocus(object sender, RoutedEventArgs e)
        {
            LostFocus_General(Hours, "Minutes");
        }
    }
}
