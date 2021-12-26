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
    public class CompositionModel : INotifyPropertyChanged
    {
        private Composition_string comstr = new Composition_string();

        public CompositionModel() { }

        public CompositionModel(Composition_string o)
        {
            comstr = o;
        }

        public int Composition_string_id
        {
            get { return comstr.Composition_string_id; }
            set
            {
                comstr.Composition_string_id = value;
                OnPropertyChanged("Composition_string_id");
            }
        }

        public decimal? Count
        {
            get { return comstr.Count; }
            set
            {
                comstr.Count = value;
                OnPropertyChanged("Count");
            }
        }

        public int? Pizza_id
        {
            get { return comstr.Pizza_id; }
            set
            {
                comstr.Pizza_id = value;
                OnPropertyChanged("Pizza_id");
            }
        }

        public int Ingredient_id
        {
            get { return comstr.Ingredient_id; }
            set
            {
                comstr.Ingredient_id = value;
                OnPropertyChanged("Ingredient_id");
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
