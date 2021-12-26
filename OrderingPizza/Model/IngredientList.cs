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
    public class IngredientList : INotifyPropertyChanged
    {
        private List<IngredientModel> allIngredient;
        private List<Ingredient> ingredient;
        private PizzaDB db = new PizzaDB();

        public IngredientList()
        {
            ingredient = db.Ingredient.ToList();
            allIngredient = db.Ingredient.ToList().Select(i => new IngredientModel(i)).ToList();
        }

        public List<IngredientModel> AllIngredient
        {
            get { return allIngredient; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
