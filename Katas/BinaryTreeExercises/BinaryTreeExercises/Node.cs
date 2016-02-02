using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExercises
{
    public class Node
    {
        public string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { }

        public Node(string value, string leftVal = null, string rightVal = null)
        {
            this.Value = value;
            this.Left = new Node() { Value = leftVal };
            this.Right = new Node() { Value = rightVal };
        }

        public Node(string value, Node leftVal = null, Node rightVal = null)
        {
            this.Value = value;
            this.Left = leftVal;
            this.Right = rightVal;
        }
    }
}
