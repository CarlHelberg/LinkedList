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

            public bool Append(T _value)
            {
                var appendThis = new Node<T>(_value);
                var tempValue = Head;
                if(tempValue == null)
                {
                    Head = appendThis;
                    Length ++;
                    return true;
                }
                else
                {
                    while(tempValue != null)
                    {
                        if(tempValue.next == null)
                        {
                            tempValue.next = appendThis;
                            Length++;
                            return true;
                        }
                        tempValue = tempValue.next;
                    }
                }
                return false;
            }
        }
        
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
