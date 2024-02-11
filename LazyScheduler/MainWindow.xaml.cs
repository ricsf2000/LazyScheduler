using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            const double resizeMargin = 370; // Adjust this value as needed

            // Get the window's bottom-left and bottom-right points
            Point bottomLeft = PointToScreen(new Point(0, ActualHeight));
            Point bottomRight = PointToScreen(new Point(ActualWidth, ActualHeight));

            // Convert the points to screen coordinates
            

            // Get the mouse position relative to the screen
            Point mousePosition = e.GetPosition(null);
            Point screenMousePosition = PointToScreen(mousePosition);

            // Check if the mouse cursor is within the resize margin of the bottom edge
            if (screenMousePosition.Y >= bottomLeft.Y - resizeMargin &&
       screenMousePosition.Y <= bottomLeft.Y + resizeMargin &&
       screenMousePosition.X >= bottomLeft.X &&
       screenMousePosition.X <= bottomRight.X)
            {
                // Prevent resizing
                this.ResizeMode = ResizeMode.NoResize;
            }
            else
            {
                // Allow resizing
                this.ResizeMode = ResizeMode.CanResize;
            }
        




    }
    }
}