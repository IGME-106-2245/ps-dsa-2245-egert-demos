using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class StackAndQueue
    {
        public StackAndQueue()
        {
            this.StackDemo();
            this.QueueDemo();
        }

        public void StackDemo()
        {
            Stack<int> intStack = new Stack<int>();
            Stack<string> stringStack = new Stack<string>();
            Stack<Player> playerStack = new Stack<Player>();

            intStack.Push(5);
            intStack.Push(10);
            intStack.Push(13);

            Console.WriteLine($"Popped value from stack is {intStack.Pop()}");
            Console.WriteLine($"Popped value from stack is {intStack.Pop()}");

            intStack.Push(42);

            Console.WriteLine($"Peeked value from stack is {intStack.Peek()}");
            Console.WriteLine($"Popped value from stack is {intStack.Pop()}");
            Console.WriteLine($"Popped value from stack is {intStack.Pop()}");

            // Console.WriteLine($"Popped value from stack is {intStack.Pop()}"); // Fails because stack is empty

            stringStack.Push("Bob");
            stringStack.Push("mary");
            stringStack.Push("Bill");

            Console.WriteLine($"String Popped value from stack is {stringStack.Pop()}");
            Console.WriteLine($"String Popped value from stack is {stringStack.Pop()}");

            Player player1 = new Player("John");
            Player player2 = new Player("Rex");
            Player player3 = new Player("Jill");

            playerStack.Push(player1);
            playerStack.Push(player2);
            playerStack.Push(player3);

            Console.WriteLine($"Player Popped value from stack is {playerStack.Pop()}");
            Console.WriteLine($"Player Popped value from stack is {playerStack.Pop()}");
        }

        public void QueueDemo()
        {
            Queue<int> intQueue = new Queue<int>();
            Queue<string> stringQueue = new Queue<string>();
            Queue<Player> playerQueue = new Queue<Player>();

            intQueue.Enqueue(5);
            intQueue.Enqueue(10);
            intQueue.Enqueue(13);

            Console.WriteLine($"Dequeued value from queue is {intQueue.Dequeue()}");
            Console.WriteLine($"Dequeued value from queue is {intQueue.Dequeue()}");

            intQueue.Enqueue(42);

            Console.WriteLine($"Peeked value from queue is {intQueue.Peek()}");
            Console.WriteLine($"Dequeued value from queue is {intQueue.Dequeue()}");
            Console.WriteLine($"Dequeued value from queue is {intQueue.Dequeue()}");

            // Console.WriteLine($"Popped value from stack is {intStack.Pop()}"); // Fails because stack is empty

            stringQueue.Enqueue("Bob");
            stringQueue.Enqueue("mary");
            stringQueue.Enqueue("Bill");

            Console.WriteLine($"String Dequeued value from queue is {stringQueue.Dequeue()}");
            Console.WriteLine($"String Dequeued value from queue is {stringQueue.Dequeue()}");

            Player player1 = new Player("John");
            Player player2 = new Player("Rex");
            Player player3 = new Player("Jill");

            playerQueue.Enqueue(player1);
            playerQueue.Enqueue(player2);
            playerQueue.Enqueue(player3);

            Console.WriteLine($"Player Dequeued value from queue is {playerQueue.Dequeue()}");
            Console.WriteLine($"Player Dequeued value from queue is {playerQueue.Dequeue()}");
        }
    }
}
