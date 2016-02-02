using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExercises
{
    public class Tree
    {
        public Node Root { get; set; }

        public void DFSPreorder(Node n, Action<Node> visit)
        {
            if (n == null)
                return;
            visit(n);
            DFSPreorder(n.Left, visit);
            DFSPreorder(n.Right, visit);
        }

        public void DFSInorder(Node n, Action<Node> visit)
        {
            if (n == null)
                return;
            DFSInorder(n.Left, visit);
            visit(n);
            DFSInorder(n.Right, visit);
        }

        public void DFSPostorder(Node n, Action<Node> visit)
        {
            if (n == null)
                return;
            DFSPostorder(n.Left, visit);
            DFSPostorder(n.Right, visit);
            visit(n);
        }

        
        public void BFS(Tree tree, Action<Node> visit)
        {
            if (tree?.Root == null)
                return;
            var q = new Queue<Node>();
            q.Enqueue(tree.Root);
            while(q.Count > 0)
            {
                var node = q.Dequeue();
                visit(node);
                if (node.Left != null)
                    q.Enqueue(node.Left);
                if (node.Right != null)
                    q.Enqueue(node.Right);
            }

        }

        public void Invert()
        {
            Invert(this.Root);
        }

        public void Invert(Node n)
        {
            if (n == null)
                return;
            var temp = n.Right;
            n.Right = n.Left;
            n.Left = temp;
            Invert(n.Left);
            Invert(n.Right);

        }
    }
}
