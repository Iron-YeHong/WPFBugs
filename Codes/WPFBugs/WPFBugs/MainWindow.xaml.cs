using System.Windows;

namespace WPFBugs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IMEPositionButton_OnClick(object sender, RoutedEventArgs e)
        {
            new IMEPosition().ShowDialog();
        }
    }
}