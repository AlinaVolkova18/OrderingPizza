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
    
        public class UserModel : INotifyPropertyChanged
        {
        PizzaDB db = new PizzaDB();

            private User user = new User();

            public UserModel() { }

            public UserModel(User u)
            {
                user = u;
            }

            public string Login
            {
                get { return user.Login; }
                set
                {
                    user.Login = value;
                    OnPropertyChanged("Login");
                }
            }

            public string Password
            {
                get { return user.Password; }
                set
                {
                    user.Password = value;
                    OnPropertyChanged("Password");
                }
            }

            public int User_id
            {
                get { return user.User_id; }
                set
                {
                    user.User_id = value;
                    OnPropertyChanged("Id_user");
                }
            }

        public void newUser(UserModel userr)
        {
            user.Login = userr.Login;
            user.Password = userr.Password;
            db.User.Add(user);
            db.SaveChanges();
        }

        //public string FI
        //{
        //    get { return user.FI; }
        //    set
        //    {
        //        user.FI = value;
        //        OnPropertyChanged("FI");
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string property = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
}
