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
    public class PizzaList : INotifyPropertyChanged
    {
        private List<PizzaModel> allPizza;
        private List<Pizza> pizza;
        private PizzaDB db = new PizzaDB();

        public PizzaList()
        {
            pizza = db.Pizza.ToList();
            allPizza = db.Pizza.ToList().Select(i => new PizzaModel(i)).ToList();
        }

        public List<PizzaModel> AllPizza
        {
            get { return allPizza; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
