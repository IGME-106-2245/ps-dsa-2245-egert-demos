using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PE1___List_Of_Objects
{
    internal class Student
    {
        private string name;
        private string major;
        private int year;

        public string Name { get { return name; } }
        public string Major { get { return major; } }
        public int Year { get { return year; } }

        public Student(string name, string major, int year)
        {
            this.name = name;
            this.major = major;
            this.year = year;
        }

        public override string ToString()
        {
            return $"{name} - {year} - {major}";
        }
    }
}
