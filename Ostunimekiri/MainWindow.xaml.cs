using System.Windows;

namespace Ostunimekiri
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Koduste varude akna avamine
        private void OpenStock_Click(object sender, RoutedEventArgs e)
        {
            StockWindow stockWindow = new StockWindow();
            stockWindow.ShowDialog();
        }
    }
}