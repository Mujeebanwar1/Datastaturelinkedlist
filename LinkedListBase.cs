namespace DataStatureOfLinkedList
{
    internal class LinkedListBase
    {
        internal Node Inseatatpaticularposition(int position, int data)
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
                Console.WriteLine("inseartvalue is " + head);
                return head;

            }




        }
    }
}