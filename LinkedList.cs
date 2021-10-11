namespace DSA
{
    //linear data structure is contains saperate operator called node
    //which contains item and next node
    //first node is called Head and last node is called tail
    //tail doesnot point anything
    //nodes are called self referencial  objects
    //Singly linked list containd info of next node
    //doubly linked list contains info of next and previous node
    public class Node
    {
        //Object for storing single node of a linked list
        //models two attributes- data and the link to the next node to thte list
        public int _data;
        public Node nextNode;

        public Node(int data)
        {
            _data = data;
        }

    }

    public class LinkedList
    {
        //Singly link list

        public Node _head;
        public LinkedList()
        {
            _head = null;
        }

        public bool isEmpty(Node node)
        {
            if (node == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            // returns the number of nodes in the list 
            // takes O(n) Time
            Node current = _head;
            var count = 0;
            while (current != null)
            {
                count += 1;
                current = current.nextNode;
            }
            return count;
        }

        public void Add(int data)
        {
            //Adds a new node containing containing data at the head of the list
            //Takes O(1) Time (Constant Time)
            var newNode = new Node(data);
            newNode.nextNode = _head;
            _head = newNode;
        }

        public int Search(int key)
        {
            //Search for the first node containing the data matches with the key
            //returning null because while loop exits 
            //which means current node data doesnot cintain a value we are searching for
            //Takes O(n) Linear Time
            Node current = _head;
            int index = 0;
            while (current != null)
            {

                if (current._data == key)
                {
                    return index;
                }
                else
                {
                    index++;
                    current = current.nextNode;
                }
            }

            return 0;
        }

        public Node InsertAt(int index, int value)
        {
            Node current = _head;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    Node newNode = new(value);
                    newNode.nextNode = _head.nextNode;
                    _head.nextNode = newNode;
                    return newNode;
                }
                else
                {
                    current = current.nextNode;
                    count++;
                }
            }

            return null;
        }

    }
}