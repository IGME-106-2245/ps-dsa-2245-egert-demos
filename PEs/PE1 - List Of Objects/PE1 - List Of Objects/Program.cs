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
        }
    }
}
