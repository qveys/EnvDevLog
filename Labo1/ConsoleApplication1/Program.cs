using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new Pupil("Quentin", 10);
            Activity a1 = new Activity("Francais", true);
            Activity a2 = new Activity("Math", true);
            Activity a3 = new Activity("Anglais", false);
            Activity a4 = new Activity("Gym", false);
            Activity a5 = new Activity("Sciences", true);

            //p1.AddActivity(a1);
            //p1.AddActivity(a2);
            //p1.AddActivity(a3);
            //p1.AddActivity(a4);
            //p1.AddActivity(a5);

            p1.AddActivity("Math");
            p1.AddActivity("Francais");

            System.Console.Write(p1);

            p1.AddEvaluation("Francais");
            p1.AddEvaluation(evaluation: 'T', title: "Math");
            p1.AddEvaluation("Anglais", 'R');

            List <Pupil> listPupils = new List<Pupil>() 
            {
                new Pupil("Mathieu", 11),
                new Pupil("Marie", 12, 5),
                new Pupil("Sophie", 14, 3),
                new Pupil("Maxime", 19, 4),
                new Pupil("Justine", 20),
                new Pupil("Antoine", 18, 3),
                new Pupil("Georges", 18, 7),
                new Pupil("Adam", 12, 5)
            };

            /*
            var pupilGrade1Plus6 = from pupil in listPupils
                                   where pupil.Grade == 1 && pupil.Age > 6
                                   select pupil;
            */

            //Expression lambda
                var pupilGrade1Plus6 = listPupils.Where(pupil => pupil.Grade == 1 && pupil.Age > 6);
            //

                Debug.WriteLine(pupilGrade1Plus6);
 
            if (pupilGrade1Plus6 != null)
            {
                System.Console.Write("\n\n\nListe des enfants de premiere annee qui ont plus de 6 ans:\n");
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil+"\n");
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

            List<Person> listPersons = new List<Person>()
            {
                new Person("Albert", 13),
                new Person("Bernard", 15),
                new Person("Chantal", 17)
            };

            var listFusion = listPersons.Union(listPupils);
            foreach (var pupil in listFusion)
            {
                System.Console.Write(pupil + "\n");
            }


            List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Quentin", 21),
                new Pupil("Maxime", 19),
                new Pupil("Marie", 14),
                new Pupil("Quentin", 21),
                new Pupil("Mathieu", 18),
                new Pupil("Quentin", 21)
            };

            IEnumerable<Pupil> listPupilsNotDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.Write(listPupilsNotDuplicated.Count());

            System.Console.Read();
        }
    }
}
