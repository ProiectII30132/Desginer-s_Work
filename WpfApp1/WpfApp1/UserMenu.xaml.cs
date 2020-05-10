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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        public UserMenu()
        {
           
            InitializeComponent();
            
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void PackIcon_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void CarsImg_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
           
        }

        private List<ProductCars> GetProducts()
        {
            return new List<ProductCars>()
            {
                new ProductCars("Produs1",4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs2", 4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs3", 4000, "Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs1",4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs2", 4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs3", 4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs1",4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs2", 4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs3", 4000, "Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs1",4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs2", 4000,"Assests/Skoda-Kamiq.png"),
                new ProductCars("Produs3", 4000,"Assests/Skoda-Kamiq.png"),

            };
    }

        private void CarText_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void CarStack_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void CarItem_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            gridCarsImage.Visibility = Visibility.Visible;
            gridParking.Visibility = Visibility.Hidden;

            var products = GetProducts();
            if (products.Count > 0)
                ListViewProducts.ItemsSource = products;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void ParkingItem_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            gridCarsImage.Visibility = Visibility.Hidden;
            gridParking.Visibility = Visibility.Visible;
        }

        private void ListViewProducts_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ProductPrezentation product = new ProductPrezentation();
            product.Show();
            this.Close();
        }

        private void ButtonAccInfo_Click(object sender, RoutedEventArgs e)
        {
            AccInfo accInfo = new AccInfo();
            accInfo.Show();
            this.Close();

        }
    }
}
