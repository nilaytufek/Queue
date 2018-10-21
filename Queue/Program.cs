using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> myQueue = new MyQueue<int>();
            Node<int> e1 = new Node<int>(1);
            myQueue.Enqueue(e1);
            Node<int> e2 = new Node<int>(2);
            myQueue.Enqueue(e2);
            Node<int> e3 = new Node<int>(3);
            myQueue.Enqueue(e3);
            //print queue
            Console.WriteLine("myQueue: " + string.Join(" ", myQueue.GetQ()));
            //dequeue
            int retVal = myQueue.Dequeue();
            Console.WriteLine("Dequeued value: " + retVal);
            //print queue again
            Console.WriteLine("myQueue: " + string.Join(" ", myQueue.GetQ()));

            //search - false
            Console.WriteLine(myQueue.Search(e1.value));
            //search - true
            Console.WriteLine(myQueue.Search(e2.value));

            Console.ReadLine();

        }
    }
}
