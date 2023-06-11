using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStatureOfLinkedList
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
            internal void list1 (int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("invaild position");
                if (position == 1)
                {

                    var newNode = new Node(data);
                    newNode.next = head;
                    head = newNode;
                }
                else
                {
                    while (position != 0)
                    {
                        if (position == 1)
                        {
                            Node node = new Node(data);

                            node.next = this.head.next;
                            head.next = node;
                            break;
                        }
                        head = head.next;

                    }
                    if (position != 1)

                        Console.WriteLine("position out of range");

                }
                Console.WriteLine("inseartvalue is : " + head);
                    
                
            }
            
            
           
            
        }
    }
}
    

