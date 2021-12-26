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
using DAL.Entity;
using System.Data.SqlClient;
using System.Data.Entity;
using OrderingPizza.ViewModel;
using System.Windows.Interactivity;
using OrderingPizza.Model;
using OrderingPizza.View;

namespace OrderingPizza
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel(null);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        public MainWindow(UserModel user)
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel(user);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
