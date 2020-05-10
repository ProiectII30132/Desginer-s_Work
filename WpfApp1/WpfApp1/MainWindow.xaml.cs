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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            this.Close();

        }

        private void fpTextBlock_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Fpas fpas = new Fpas();
            this.Close();
            fpas.Show();
        }

        private void signUpTBlock_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            SignUp signup = new SignUp();
            this.Close();
            signup.Show();
        }

        private void Ellipse_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(1);

        }
    }
}
