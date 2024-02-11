using System.Collections.ObjectModel;
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
        public int TotalHours = 0;
        public int TotalDifficulty = 0;
        ObservableCollection<Assignment> assignmentList = new ObservableCollection<Assignment>();
        public ObservableCollection<Assignment> AssignmentList;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        

    }
}