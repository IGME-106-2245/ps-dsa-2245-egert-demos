namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dictionary <int, string> intKeyDictionary = new Dictionary<int, string>();
            intKeyDictionary.Add(3, "Chris");
            intKeyDictionary.Add(5, "Bob");
           // intKeyDictionary.Add(5, "Craig"); // Keys have to be unique!

            intKeyDictionary[7] = "Mary";
            intKeyDictionary[7] = "Susan";

            Console.WriteLine($"The number of elements are {intKeyDictionary.Count}");

            Console.WriteLine(intKeyDictionary[3]);
            Console.WriteLine(intKeyDictionary[5]);
            if (intKeyDictionary.ContainsKey(8))
            {
                Console.WriteLine(intKeyDictionary[8]);
            }

            Player player1 = new Player("Jill");
            Player player2 = new Player("Fred");

            Dictionary<string, Player> stringKeyDictionary= new Dictionary<string, Player>();

            stringKeyDictionary[player1.Name] = player1;
            stringKeyDictionary[player2.Name] = player2;

            if (stringKeyDictionary.ContainsKey("Jill"))
            {
                Console.WriteLine(stringKeyDictionary["Jill"].Name);
            }

            Dictionary<Player, string> playerKeyDictionary = new Dictionary<Player, string>();

            playerKeyDictionary.Add(player1, "first person in party");
            playerKeyDictionary.Add(player2, "second person in party");

            Console.WriteLine(playerKeyDictionary[player1]);

            Console.WriteLine(player1.GetHashCode());
            Console.WriteLine(player2.GetHashCode());

            //player1 = player2;   // Breaks because hash code is the same when copying reference to player1

            //playerKeyDictionary.Add(player1, "first person in party");
            //playerKeyDictionary.Add(player2, "second person in party");

            Console.WriteLine(player1.GetHashCode());
            Console.WriteLine(player2.GetHashCode());

            foreach (KeyValuePair<Player, string> kvp in playerKeyDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key.Name} Value: {kvp.Value}");
            }


        }
    }
}
