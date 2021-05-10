using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Guest_form
{
    public class User
    {
        public long Id { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string login { get; private set; }
        public string type { get; private set; }
        public User(long Id, string name, string surname, string login, string type)
        {
            this.Id = Id;
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.type = type;
        }
    }
}
