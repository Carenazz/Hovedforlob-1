using System;
using System.Collections.Generic;

namespace Datastrukturer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("One");
            //numbers.Enqueue("Two");
            //numbers.Enqueue("Three");
            //numbers.Enqueue("Four");
            //numbers.Enqueue("Five");
            //numbers.Enqueue("Six");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
            //Console.WriteLine("Peek at the next item to dequeue: {0}", numbers.Peek());
            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            //Console.WriteLine("Contents of the first copy: ");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            Mqueue mq = new Mqueue();
            mq.EnQueue("One");
            mq.EnQueue("Two");
            mq.EnQueue("Three");
            mq.EnQueue("Four");
            mq.EnQueue("Five");
            mq.EnQueue("Six");

            Console.WriteLine(mq.DeQueue());
            Console.WriteLine(mq.DeQueue());
            Console.WriteLine(mq.DeQueue());
        }
    }
}
