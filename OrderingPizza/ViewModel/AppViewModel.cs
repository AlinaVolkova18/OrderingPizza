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
    class ApplicationViewModel : INotifyPropertyChanged
    {
        UserModel user;
        public UserModel User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        PizzaList allPizza = new PizzaList();

        List<PizzaModel> pizza;
        public List<PizzaModel> PizzaShow
        {
            get { return pizza; }
            set
            {
                pizza = value;
                OnPropertyChanged("PizzaShow");
            }
        }

        PizzaModel selectedPizza;

        public OrderingPizza.Model.PizzaModel SelectedPizza
        {
            get { return selectedPizza; }
            set
            {
                selectedPizza = value;
                OnPropertyChanged("selectedPizza");
            }
        }

        PizzaModel selectedCount;

        public OrderingPizza.Model.PizzaModel SelectedCount
        {
            get { return selectedCount; }
            set
            {
                selectedCount = value;
                OnPropertyChanged("selectedPizza");
            }
        }

        public ApplicationViewModel(UserModel user)
        {
            this.User = user;

            PizzaShow = new List<PizzaModel> { };
            foreach (PizzaModel pi in allPizza.AllPizza)
            {
                PizzaShow.Add(new PizzaModel() { Pizza_id = pi.Pizza_id, Name = pi.Name, Cost = pi.Cost, Composition = pi.Composition, Availability = pi.Availability, Custom = pi.Custom, Size = pi.Size, Picture = pi.Picture });
            }
        }

        private RelayCommand logInCommand;
        public RelayCommand LogInCommand
        {
            get
            {
                return logInCommand ??
                  (logInCommand = new RelayCommand(obj =>
                  {
                      Authorization login = new Authorization(); //close window
                      login.Show();
                  }));
            }
        }

        private RelayCommand addInStock;
        public RelayCommand AddInStock
        {
            get
            {
                return addInStock ??
                  (addInStock = new RelayCommand(obj =>
                  {
                      AllPizzaList all = new AllPizzaList(selectedPizza, selectedCount); //close window
                      all.Show();
                  }));
            }
        }

        private RelayCommand createPizza;
        public RelayCommand CreatePizza
        {
            get
            {
                return createPizza ??
                  (createPizza = new RelayCommand(obj =>
                  {
                      CreateYourPizza create = new CreateYourPizza(); //close window
                      create.Show();
                  }));
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
