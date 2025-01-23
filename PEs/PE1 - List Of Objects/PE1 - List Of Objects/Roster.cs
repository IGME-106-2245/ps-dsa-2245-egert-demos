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
            // todo - make sure this student isn't already in the roster & print confirmation message
            // implementing the rest here only to allow for testing with the adding file support demo later
            students.Add(student);
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
