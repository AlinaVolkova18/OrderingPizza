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
    class PizzaListViewModel : INotifyPropertyChanged
    {
        PizzaList allPizza = new PizzaList();
        PizzaModel selectedPizza;
       // CompositionModel composition;
       // IngredientModel ingredient;

        //private List<Composition_string> allComposition;
        CompositionList allComposition = new CompositionList();
        IngredientList allIngredient = new IngredientList();
        //public ObservableCollection<CompositionModel> Compositions { get; set; }

       // public ObservableCollection<IngredientModel> Ingredients { get; set; }
        List<PizzaModel> pizza;
        List<IngredientModel> ingredient;
        List<CompositionModel> composition;

        public List<CompositionModel> Compositions
        {
            get { return composition; }
            set
            {
                composition = value;
                OnPropertyChanged("Composition");
            }
        }

        public List<IngredientModel> Ingredients
        {
            get { return ingredient; }
            set
            {
                ingredient = value;
                OnPropertyChanged("Ingredient");
            }
        }

        public PizzaModel SelectedPizza
        {
            get { return selectedPizza; }
            set
            {
                selectedPizza = value;
                OnPropertyChanged("selectedPizza");
            }
        }

        //private void FillComposition(int pizzaId)
        //{
        //    var r = allComposition.Where(i => i.Pizza_id == pizzaId).Select(i => i).ToList();
        //    Composition = new ObservableCollection<Composition_string>(r);
        //    OnPropertyChanged("Composition");
        //}


        public PizzaListViewModel(PizzaModel all)
        {
            selectedPizza = all;

            Compositions = new List<CompositionModel> { };
            // Compositions = new ObservableCollection<CompositionModel> { };
            foreach (CompositionModel or in allComposition.AllComposition)
            {
                Compositions.Add(new CompositionModel() { Composition_string_id = or.Composition_string_id, Count = or.Count, Pizza_id = or.Pizza_id, Ingredient_id = or.Ingredient_id });
            }

            Ingredients = new List<IngredientModel> { };
            // Ingredients = new ObservableCollection<IngredientModel> { };
            foreach (IngredientModel or in allIngredient.AllIngredient)
            {
                Ingredients.Add(new IngredientModel() { Ingredient_id = or.Ingredient_id, Name = or.Name, Cost = or.Cost, Availability = or.Availability });
            }

            //Ingredients = Ingredients
            //    .Join(Compositions, c => c.Ingredient_id, i => i.Pizza_id, (i, c) => new { i.Ingredient_id, i.Name, i.Cost, i.Availability })
            //    .Where(i => i.Ingredient_id == selectedPizza.Pizza_id)
            //    .Select(i => new IngredientModel
            //    {
            //       // Ingredient_id = i.Ingredient_id,
            //        Name = i.Name,
            //        //Cost = i.Cost,
            //        //Availability = i.Availability,
            //    })
            //    .ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

