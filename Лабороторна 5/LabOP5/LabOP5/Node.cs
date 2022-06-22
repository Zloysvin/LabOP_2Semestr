using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP5
{
    public class Node
    {
        public Node Left;
        public Node Right;

        public char Value { get; private set; }

        public Node(char element)
        {
            Value = element;
        }
    }
}
