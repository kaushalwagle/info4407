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

namespace Deliv6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lbOutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnShowEmployees_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();

        }

        private void btnShowCustomers_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();

        }

        private void btnShowPurchases_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();

        }

        private void btnGetByID_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();
            int idToGet;
            if (int.TryParse(txtID.Text, out idToGet))
            {
                txtID.Background = new SolidColorBrush(Colors.White);
                if (rbEmployee.IsChecked == true)
                {
                    lbOutput.Items.Add(DAL.GetEmployee(idToGet));
                }
                else if (rbPurchase.IsChecked == true)
                {
                    //lbOutput.Items.Add(DAL.GetPurchase(idToGet));
                }
                else
                {
                    //lbOutput.Items.Add(DAL.GetCustomer(idToGet));
                }
            }
            else
            {
                txtID.Background = new SolidColorBrush(Colors.Pink);
            }
        }
        private void rb_Click(object sender, RoutedEventArgs e)
        {
            RadioButton owner = (RadioButton)sender;
            string btnText = "Get ";
            if (owner.Name.Contains("Employee"))
            {
                btnText += "Employee";
            }
            else if (owner.Name.Contains("Customer"))
            {
                btnText += "Customer";
            }
            else if (owner.Name.Contains("Purchase"))
            {
                btnText += "Purchase";
            }
            else
            {
                // should not hit this
                btnText += "Unknown";
            }
            btnGetByID.Content = btnText;
        }
    }
}
