using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PersonComparer : IEqualityComparer<Person>
    {

        public bool Equals(Person p1, Person p2)
        {
            if ((p1 == p2) || (p1.Name.ToString().Equals(p2.Name.ToString()) && p1.Age == p2.Age))
                return true;
            else return false;
        }

        public int GetHashCode(Person p)
        {
            return (int) Math.Pow(p.GetHashCode(), p.Age);
        }
        
    }
}
