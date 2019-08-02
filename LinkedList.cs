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

            public override string ToString()
            {
                string toReturn = "(";
                var tempValue = Head;
                var tempNext = tempValue.next;
                while(tempValue != null)
                {
                    tempNext = tempValue.next;
                    toReturn += tempValue.value;
                    if(tempNext != null)
                    {
                        toReturn += ", ";
                    }
                    tempValue = tempValue.next; 
                }
                toReturn += ")";
                System.Console.WriteLine(toReturn);
                return toReturn;
            }
        }
        
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
