using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Activity
    {
        private String title;
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        private Boolean isCompulsory;
        public Boolean IsCompulsory
        {
            get { return isCompulsory; }
            set { isCompulsory = value; }
        }

        public Activity(String title, Boolean isCompulsory)
        {
            if (String.IsNullOrEmpty(title))
                throw new ArgumentNullException("title");
            Title = title;
            IsCompulsory = isCompulsory;
        }

        public override string ToString()
        {
            return Title + ((IsCompulsory) ? " (Obligatoire)" : "");
        }
    }
}
