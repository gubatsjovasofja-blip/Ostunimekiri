using System.Windows;

namespace Ostunimekiri
{
    public partial class ShoppingWindow : Window
    {
        public ShoppingWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductTextBox.Text))
            {
                MessageBox.Show("Palun sisesta toote nimi!");
                return;
            }

            ShoppingListBox.Items.Add(ProductTextBox.Text);
            ProductTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ShoppingListBox.Items.Remove(ShoppingListBox.SelectedItem);
        }

        private void MarkButton_Click(object sender, RoutedEventArgs e)
        {
            int index = ShoppingListBox.SelectedIndex;
            string product = ShoppingListBox.Items[index].ToString();

            if (!product.EndsWith(" (ostetud)"))
            {
                ShoppingListBox.Items[index] = product + " (ostetud)";
            }
        }
    }
}