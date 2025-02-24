﻿using System;
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
        private string filename;

        public Roster(string rosterName)
        {
            this.rosterName = rosterName;
            this.students = new List<Student>();

            filename = "../../../" + rosterName + ".txt";

            //Check for the file and see if it exists

            //If the file exists, load in the data and populate the students list

            //If the file does not exist, no more work needs to be completed within the constructor
        }

        public void Save()
        {
            //Create streamwrite variable
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(filename);

                //Write out information for each student in the students list
                foreach(Student s in students)
                {
                    writer.WriteLine($"{s.Name},{s.Major},{s.Year}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Close the file if it is open
            if(writer != null)
            {
                writer.Close();
            }
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
