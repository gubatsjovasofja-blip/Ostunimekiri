using System.Collections.Generic;
using System.Windows;

namespace Ostunimekiri
{
    public partial class StockWindow : Window
    {
        // Toodete nimekiri
        private static List<string> varud = new List<string>();

        public StockWindow()
        {
            InitializeComponent();

            // Olemasolevate toodete kuvamine
            foreach (string toode in varud)
            {
                lstVarud.Items.Add(toode);
            }
        }

        // Toote lisamine
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string toode = txtToode.Text;
            string kogus = txtKogus.Text;
            string uhik = cmbUhik.Text;

            // Toote nime kontroll
            if (toode.Trim() == "")
            {
                MessageBox.Show("Sisesta toote nimi!");
                return;
            }

            // Koguse kontroll
            if (!decimal.TryParse(kogus, out decimal arv) || arv <= 0)
            {
                MessageBox.Show("Sisesta õige kogus!");
                return;
            }

            // Ühiku kontroll
            if (cmbUhik.SelectedIndex == -1)
            {
                MessageBox.Show("Vali ühik!");
                return;
            }

            string kirje = toode + " - " + kogus + " " + uhik;

            varud.Add(kirje);
            lstVarud.Items.Add(kirje);

            // Väljade puhastamine
            txtToode.Clear();
            txtKogus.Clear();
            cmbUhik.SelectedIndex = -1;
        }

        // Toote kustutamine
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lstVarud.SelectedIndex != -1)
            {
                int index = lstVarud.SelectedIndex;

                varud.RemoveAt(index);
                lstVarud.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Vali toode!");
            }
        }

        // Tagasi peaaknasse
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}