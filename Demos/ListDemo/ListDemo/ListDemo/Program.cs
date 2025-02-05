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
            try
            {
 //               Console.WriteLine("Element -1 of the MyStringList " + names[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Try using the Generic version called MyList

            MyList<string> list = new MyList<string>();
            list.Add("Bob");
            list.Add("Mary");
            list.Add("Paul");

            Console.WriteLine("The value of our string generic list is " + list[1] + " at position 2");

            MyList<int> myIntList = new MyList<int>();
            myIntList.Add(1);
            myIntList.Add(42);
            myIntList.Add(3);

            Console.WriteLine("The value of our int generic list is " + myIntList[1] + " at position 2");

            Dictionary<int,string> myDictionary = new Dictionary<int,string>();
            MyList<Dictionary<int,string>> myDictionaryList = new MyList<Dictionary<int,string>>();

            myDictionaryList.Add(myDictionary);

        }
    }
}
