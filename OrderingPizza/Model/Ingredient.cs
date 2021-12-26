using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DAL.Entity;

namespace OrderingPizza.Model
{
    public class IngredientModel : INotifyPropertyChanged
    {
        private Ingredient ingre = new Ingredient();

        public IngredientModel() { }

        public IngredientModel(Ingredient ing)
        {
            ingre = ing;
        }

        public int Ingredient_id
        {
            get { return ingre.Ingredient_id; }
            set
            {
                ingre.Ingredient_id = value;
                OnPropertyChanged("Ingredient_id");
            }
        }

        public string Name
        {
            get { return ingre.Name; }
            set
            {
                ingre.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public decimal Cost
        {
            get { return ingre.Cost; }
            set
            {
                ingre.Cost = value;
                OnPropertyChanged("Cost");
            }
        }

        public int Availability
        {
            get { return ingre.Availability; }
            set
            {
                ingre.Availability = value;
                OnPropertyChanged("Availability");
            }
        }

        public string Name1
        {
            get { return Name1; }
            set
            {
                Name1 = value;
                OnPropertyChanged("Name1");
            }
        }

        public decimal Cost1
        {
            get { return Cost1; }
            set
            {
                Cost1 = value;
                OnPropertyChanged("Cost1");
            }
        }

        public int Availability1
        {
            get { return Availability1; }
            set
            {
                Availability1 = value;
                OnPropertyChanged("Availability1");
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
