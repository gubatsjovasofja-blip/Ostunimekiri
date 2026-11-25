using System.Windows;

namespace Ostunimekiri
{
    public partial class StockWindow : Window
    {
        public StockWindow()
        {
            InitializeComponent();
        }

        // Toote lisamine
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string toode = txtToode.Text;
            string kogus = txtKogus.Text;
            string uhik = cmbUhik.Text;

            lstVarud.Items.Add(toode + " - " + kogus + " " + uhik);

            // Väljade puhastamine
            txtToode.Clear();
            txtKogus.Clear();
            cmbUhik.SelectedIndex = -1;
        }

        // Toote kustutamine
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lstVarud.SelectedItem != null)
            {
                lstVarud.Items.Remove(lstVarud.SelectedItem);
            }
        }

        // Tagasi peaaknasse
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}