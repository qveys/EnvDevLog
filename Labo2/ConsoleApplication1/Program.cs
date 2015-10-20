using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrivateContact p1 = new PrivateContact("VEYS", "Quentin", "056841372", "qv@gmail.com");
            DateTime d1 = new DateTime(2015, 10, 18);
            PrivateContact p2 = new PrivateContact("RAPPE", "Maxime", "0494807793", "m.ra@gmail.com", d1);

            if (p1.BirthdayWish())
            {
                System.Console.Write(p1.ToString() + "\nBon anniversaire!\n");
            }

            if (p2.BirthdayWish())
            {
                System.Console.Write(p2.ToString() + "\nBon anniversaire!\n");
            }

            System.Console.Read();

        }
    }
}
