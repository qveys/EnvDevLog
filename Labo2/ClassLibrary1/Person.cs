using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Person
    {
        private String name;
        private String lastname;

        public String Name { get; set; }
        public String Lastname { get; set; }

        public Person(String name, String lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public override string ToString()
        {
            return name + " " + lastname;
        }

        public abstract bool BirthdayWish();

    }
}
