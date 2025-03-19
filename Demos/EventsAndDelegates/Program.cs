namespace EventsAndDelegates
{
    internal class Program
    {

        public delegate int UseTwoNumbersDelegate(int a, int b);

        static void Main(string[] args)
        {
            int a = SmartConsole.Prompt("Enter a number: ", 0, 10);
            int b = SmartConsole.Prompt("Enter another number: ", 0, 10);
            int choice = SmartConsole.Prompt("Do you want to (1) add, (2) multiple, or (3) subtract?", 1, 4);

            UseTwoNumbersDelegate myMathMethod;

            switch(choice)
            {
                case 1:
                    myMathMethod = AddTwoNumbers;
                    break;
                case 2:
                    myMathMethod = MultiplyTwoNumbers;
                    break;
                case 3:
                    myMathMethod = SubtractTwoNumbers;
                    break;
                default:
                    myMathMethod = null;
                    break;
            }

            if (myMathMethod != null)
            {
                Console.WriteLine("Result: " + myMathMethod(a, b));
            }

        }

        public static int AddTwoNumbers(int num1, int num2)
        { 
            return num1 + num2; 
        }

        public static int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int SubtractTwoNumbers(int num1, int num2)
        {
            return (num1 - num2);
        }
    }
}
