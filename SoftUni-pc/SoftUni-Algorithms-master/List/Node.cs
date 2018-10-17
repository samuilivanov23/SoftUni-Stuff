using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Node
    {
        private object element;
        private Node next;

        public object Eement
        {
            get { return this.element; }
            set { this.element = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node(object element, Node prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        public Node(object element)
        {
            this.element = element;
        }
    }
}
