namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStringList names = new MyStringList();
            names.Add("Shiro");
            names.Add("Pax");
            names.Add("Lacey");

            Console.WriteLine("Element 2 of the MyStringList " + names[1]);
            names[2] = "Snoopy";
            Console.WriteLine("Element 3 of the MyStringList " + names[2]);
            Console.WriteLine("Element -1 of the MyStringList " + names[10]);

        }
    }
}
