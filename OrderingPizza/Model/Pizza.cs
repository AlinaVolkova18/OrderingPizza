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
     public class PizzaModel : INotifyPropertyChanged
    {
        private Pizza piz = new Pizza();

        public PizzaModel() { }

        public PizzaModel(Pizza pi)
        {
            piz = pi;
        }

        public string Name
        {
            get { return piz.Name; }
            set
            {
                piz.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Pizza_id
        {
            get { return piz.Pizza_id; }
            set
            {
                piz.Pizza_id = value;
                OnPropertyChanged("Pizza_id");
            }
        }

        public decimal Cost
        {
            get { return piz.Cost; }
            set
            {
                piz.Cost = value;
                OnPropertyChanged("Cost");
            }
        }

        public string Composition
        {
            get { return piz.Composition; }
            set
            {
                piz.Composition = value;
                OnPropertyChanged("Composition");
            }
        }

        public int? Availability
        {
            get { return piz.Availability; }
            set
            {
                piz.Availability = value;
                OnPropertyChanged("Availability");
            }
        }

        public int? Custom
        {
            get { return piz.Custom; }
            set
            {
                piz.Custom = value;
                OnPropertyChanged("Custom");
            }
        }

        public string Size
        {
            get { return piz.Size; }
            set
            {
                piz.Size = value;
                OnPropertyChanged("Size");
            }
        }

        public string Picture
        {
            get { return piz.Picture; }
            set
            {
                piz.Picture = value;
                OnPropertyChanged("Picture");
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
