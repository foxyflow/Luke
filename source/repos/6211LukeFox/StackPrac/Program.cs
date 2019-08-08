using System;
using System.Collections;

namespace StackPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************myStack***********");
            Stack myStack = new Stack();

            myStack.Push("The");
            myStack.Push("quick");
            myStack.Push("brown");
            myStack.Push("fox");
            myStack.Push(true);
            myStack.Push(false);
            myStack.Push(3.0);

            //PrintValues(myStack);// this doesn't work -- was in the documentation.
            Console.WriteLine(myStack.Pop()); //goodbye 3.0
            Console.WriteLine(myStack.Pop()); //goodbye false.
            Console.WriteLine(myStack.Peek()); //shows top of stack: True
            Console.WriteLine("popping off the top {0}", myStack.Pop());//True
            Console.WriteLine(myStack.Peek());//fox
            Console.WriteLine(myStack.Count);//displays 4

            Console.WriteLine("***************my Queue**************************");

            Queue myQ = new Queue();
            myQ.Enqueue("hello");
            myQ.Enqueue("World");
           

      

            Console.WriteLine(myQ.Count);//2
            Console.WriteLine(myQ.Dequeue());//kicked out "hello"
            Console.WriteLine(myQ.Count);//1
            Console.WriteLine(myQ.Peek());//"World" is all that's left.

            Console.ReadLine();

        }
    }
}
