using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pupil:Person
    {
        private int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private List<Activity> listActivities;
        public List<Activity> ListActivities
        {
            get { return listActivities; }
            set { listActivities = value; }
        }

        private char[] pupilEvaluations;
        public char[] PupilEvaluations
        {
            get { return pupilEvaluations; }
            set { pupilEvaluations = value; }
        }

        public Pupil(String name, int age, int grade) : base(name,age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            PupilEvaluations = new char[Parameter.nbActiChoisies];
        }

        public Pupil(String name, int age) : this(name, age, 1){}

        public void AddActivity (Activity name)
        {
            ListActivities.Add(name);
        }

        public override string ToString()
        {
            return Header();
        }

        private string Header()
        {
            string ch = base.ToString() + ((ListActivities.Count() != 0) ? " a choisi: \n" : " n'a pas encore choisi d'activité");
            for (int i = 0; i < ListActivities.Count(); i++)
            {
                ch += ListActivities[i].ToString() + "\n";
            }
            return ch;
        }

        public void AddEvaluation (String title = null, char evaluation = (char) Parameter.eval.Satisfaisant)
        {
            int i = 0;
            if (title != null)
            {
                foreach (Activity act in listActivities)
                {
                    if (act.Title.Equals(title)) break;
                    i++;
                }

                PupilEvaluations[i] = evaluation;
            }
        }

        public char GetEvaluationFor(String activityName)
        {
            int i = 0;
            if (activityName != null)
            {
                foreach (Activity activity in ListActivities)
                {
                    if (activity.Title.Equals(activityName)) 
                        return PupilEvaluations[i];
                    i++;
                }
            }
            throw new KeyNotFoundException("ListActivities");
        }
    }
}
