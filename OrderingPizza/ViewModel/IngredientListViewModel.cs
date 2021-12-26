using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using System.Data.SqlClient;
using System.Data.Entity;
using OrderingPizza.View;
using OrderingPizza.Model;

namespace OrderingPizza.ViewModel
{
    class IngredientListViewModel : INotifyPropertyChanged
    {
        IngredientList allIngredient = new IngredientList();
        IngredientModel selectedIngredient;

        List<IngredientModel> ingredient;
        public List<IngredientModel> IngredientShow
        {
            get { return ingredient; }
            set
            {
                ingredient = value;
                OnPropertyChanged("IngredientShow");
            }
        }

        public IngredientModel SelectedIngredient
        {
            get { return selectedIngredient; }
            set
            {
                selectedIngredient = value;
                OnPropertyChanged("selectedIngredient");
            }
        }

        public IngredientListViewModel(IngredientModel ingredient)
        {
            selectedIngredient = ingredient;

            IngredientShow = new List<IngredientModel> { };
            foreach (IngredientModel ing in allIngredient.AllIngredient)
            {
                IngredientShow.Add(new IngredientModel() { Name = ing.Name, Cost = ing.Cost });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

