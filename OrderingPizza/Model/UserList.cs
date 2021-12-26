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
    class UserList : INotifyPropertyChanged
    {
        private List<UserModel> allUsers;
        private List<User> users;
        private PizzaDB db = new PizzaDB();

        public UserList()
        {
            users = db.User.ToList();
            allUsers = db.User.ToList().Select(i => new UserModel(i)).ToList();
        }

        public List<UserModel> AllUsers
        {
            get { return allUsers; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
