using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
        internal interface IQueue<T>
        {
            /// <summary>
            /// Gets the current count of items in the queue
            /// </summary>
            int Count { get; }

            /// <summary>
            /// Gets whether or not there are items in the queue
            /// </summary>
            bool IsEmpty { get; }

            /// <summary>
            /// Look at and return the front of the queue.  Returns the default
            /// value of T or throws an exception if the queue is empty.
            /// </summary>
            T Peek();

            /// <summary>
            /// Adds new data to the end of the queue
            /// </summary>
            /// <param name="item">The data to add</param>
            void Enqueue(T item);

            /// <summary>
            /// Removes and returns the data in the front
            /// of the queue.  Returns the default
            /// value of T or throws an exception if the queue is empty.
            /// </summary>
            T Dequeue();
        }

}
