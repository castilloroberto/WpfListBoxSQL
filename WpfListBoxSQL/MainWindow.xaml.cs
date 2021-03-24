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

namespace WpfListBoxSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> listOfCustomers = new List<Customer>();
        public MainWindow()
        {
            InitializeComponent();
            LoadAllCustomers();
            FillListBox();

        }
        private void FillListBox()
        {
            listBoxCustomers.ItemsSource = listOfCustomers;
            listBoxCustomers.DisplayMemberPath = "FullInfo";
        }
        private void LoadAllCustomers()
        {
            DataAccess db = new DataAccess();
            listOfCustomers = db.GetAllCustomers();

        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();
            listOfCustomers = db.GetCustomers(searchTextBox.Text);
            FillListBox();
        }
    }
}
