using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
        class Node<T>
        {
            public T value;
            public Node<T> next;
            public Node(T nodeInput)
            {
                value = nodeInput;
                next = null;
            }
        }
         class  LinkedList<T>
        {
            public   Node<T> Head;
            public int Length = 0;

            public void Prepend(T prependValue)
            {
                Node<T> PrependThis = new Node<T>(prependValue);
                PrependThis.next = Head;
                Head = PrependThis;
                Length++;
            }
            
            public void Append(T appendValue)
            {
                var tempValue = Head;
                var appendHere = tempValue;
                Node<T> AppendThis = new Node<T>(appendValue);
                if(Length == 0)
                {
                    AppendThis.next = Head;
                    Head = AppendThis;
                    Length++;
                    return;
                }
                if (Length > 0)
                {
                    while(tempValue != null)
                    {
                        if(tempValue.next == null)
                        {
                            tempValue.next = AppendThis;
                            Length ++;
                            break;
                        } 
                        tempValue = tempValue.next;
                    }
                }        
            }

            public void DeleteAtIndex(int deleteIndex)
            {
                var tempValue = Head;
                var beforeDeleted = tempValue;
                var afterDeleted = tempValue.next;
                int currentIndex = 0;

                if(deleteIndex < Length -1)
                {
                    while(currentIndex < deleteIndex)
                    {
                        beforeDeleted = tempValue;
                        tempValue = tempValue.next;
                        afterDeleted = tempValue.next;
                        currentIndex++;
                    }
                    tempValue = null;
                    beforeDeleted.next = afterDeleted;
                }
                else
                {
                    System.Console.WriteLine("Index to delete was not found. Try ToString() to verify the Index.");
                }
            }

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
