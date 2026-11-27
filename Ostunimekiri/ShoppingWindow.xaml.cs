using System.Collections.Generic;
using System.Windows;

namespace Ostunimekiri
{
    public partial class ShoppingWindow : Window
    {
        private static List<string> products = new List<string>();

        public ShoppingWindow()
        {
            InitializeComponent();

            foreach (string product in products)
            {
                ShoppingListBox.Items.Add(product);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductTextBox.Text))
            {
                MessageBox.Show("Palun sisesta toote nimi!");
                return;
            }

            products.Add(ProductTextBox.Text);
            ShoppingListBox.Items.Add(ProductTextBox.Text);
            ProductTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ShoppingListBox.SelectedItem == null)
            {
                MessageBox.Show("Palun vali toode!");
                return;
            }

            int index = ShoppingListBox.SelectedIndex;

            products.RemoveAt(index);
            ShoppingListBox.Items.RemoveAt(index);
        }

        private void MarkButton_Click(object sender, RoutedEventArgs e)
        {
            if (ShoppingListBox.SelectedItem == null)
            {
                MessageBox.Show("Palun vali toode!");
                return;
            }

            int index = ShoppingListBox.SelectedIndex;
            string product = products[index];

            if (!product.EndsWith(" (ostetud)"))
            {
                products[index] = product + " (ostetud)";
                ShoppingListBox.Items[index] = products[index];
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}