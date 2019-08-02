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

            private object GetIndex(int _index)
            {
                var IndexReturn = Head;
                for(int i = 0; i < Length; i++)
                {
                    if (i == _index)
                    {
                        return IndexReturn.value;
                    }
                    IndexReturn = IndexReturn.next;
                }
                throw new Exception(" The index you are looking for does not exist");

            }
            
            public object this[int _index]
            {
                get
                {
                    return (GetIndex(_index));
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
