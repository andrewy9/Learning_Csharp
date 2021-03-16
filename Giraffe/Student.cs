using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) //Constructuor
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors() //Method
        {
            if(gpa > 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
