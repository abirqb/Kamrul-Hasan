using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScootAllen
{
    class Book
    {
        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }
        public void AddGrade(double x)
        {
            grades.Add(x);
        }

        private List<double> grades;
        private string name;
        

    }
}
