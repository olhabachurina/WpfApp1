using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal totalAmount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddPurchaseClick(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(purchaseTextBox.Text, out decimal purchaseAmount))
            {
                totalAmount += purchaseAmount;
                totalTextBlock.Text = "Общая сумма: " + totalAmount.ToString("C"); 
                purchaseTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }
    }
}
