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
   public class CompositionList : INotifyPropertyChanged
    {
        private List<CompositionModel> allComposition;
        private List<Composition_string> compositions;
        private PizzaDB db = new PizzaDB();

        public CompositionList()
        {
            compositions = db.Composition_string.ToList();
            allComposition = db.Composition_string.ToList().Select(i => new CompositionModel(i)).ToList();
        }

        public List<CompositionModel> AllComposition
        {
            get { return allComposition; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
