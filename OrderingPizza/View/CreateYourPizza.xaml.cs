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

namespace OrderingPizza.View
{
    /// <summary>
    /// Логика взаимодействия для CreateYourPizza.xaml
    /// </summary>
    public partial class CreateYourPizza : Window
    {
        public CreateYourPizza()
        {
            InitializeComponent();
            DataContext = new IngredientListViewModel(null);
        }
    }
}
