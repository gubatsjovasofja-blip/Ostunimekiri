using System.Windows;

namespace Ostunimekiri
{
    public partial class StockWindow : Window
    {
        public StockWindow()
        {
            InitializeComponent();
        }

        // Tagasi peaaknasse
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}