using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1___List_Of_Objects
{
    internal class Roster
    {
        private string rosterName;
        private List<Student> students;

        public Roster(string rosterName)
        {
            this.rosterName = rosterName;
            this.students = new List<Student>();
        }

        public Student AddStudent()
        {
            return null;
        }

        public void AddStudent(Student student) 
        {

        }

        public Student SearchByName(string studentName)
        {
            return null;
        }

        public void DisplayRoster()
        {

        }
    }
}
