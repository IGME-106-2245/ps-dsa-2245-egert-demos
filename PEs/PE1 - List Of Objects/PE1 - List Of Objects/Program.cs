namespace PE1___List_Of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Student
            Student student1 = new Student("Sam", "GDD", 5);
            Console.WriteLine(student1.ToString());

            //Create Roster
            Roster roster = new Roster("Roster 1");

            TestRoster();

        }

        private static void TestRoster()
        {
            Roster roster = new Roster("Sample");
            roster.AddStudent(new Student("Shiro", "Cooking", 4));
            roster.AddStudent(new Student("Lacy", "Baking", 3));
            roster.AddStudent(new Student("Pax", "Barking", 2));
            roster.AddStudent(new Student("Aiden", "Eating", 1));
        }
    }
}
