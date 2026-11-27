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
            ShoppingListBox.Items.Add(ProductTextBox.Text);
        }
    }
}