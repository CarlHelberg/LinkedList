using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
        
         class  LinkedList<T>
        {
            public class Node<T>
            {
                public T value;
                public Node<T> next;
                public Node(T nodeInput)
                {
                    value = nodeInput;
                    next = null;
                }
            }

            public Node<T> Head;
            public int Length = 0;

            public void Traverse()
            {
                var tempValue = Head;
                while(tempValue != null)
                {
                    
                    System.Console.WriteLine(tempValue.value);
                    tempValue = tempValue.next; 
                }
            }
        }
        
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
