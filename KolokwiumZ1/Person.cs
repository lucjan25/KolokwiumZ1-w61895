using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumZ1
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string email { get; set; }


        public Person(int ID, string Name, string Surname, string email)
        {
            this.ID = ID;
            this.Name = Name;
            this.Surname = Surname;
            this.email = email;
        }

        public Person()
            : this(0, "", "", "")
        { }
    }
}
