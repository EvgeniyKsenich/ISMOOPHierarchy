using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Student:Human, ICloneable, IComparable<Student>
    {
        public Student(string name, string surname):base(name, surname)
        {

        }
        public object Clone()
        {
            return new Student(this.Name, this.Surname);
        }
        public int CompareTo(Student other)
        {
            Human tmp = new Human(other.Name, other.Surname);
            return base.CompareTo(tmp);
        }
    }
}
