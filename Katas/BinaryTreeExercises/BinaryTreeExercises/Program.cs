using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = BuildTree();
            tree.DFSPreorder(tree.Root, (n) => Console.WriteLine(n.Value));
            Console.ReadKey();
            tree.DFSInorder(tree.Root, (n) => Console.WriteLine(n.Value));
            Console.ReadKey();
            tree.DFSPostorder(tree.Root, (n) => Console.WriteLine(n.Value));
            Console.ReadKey();
            tree.BFS(tree, (n) => Console.WriteLine(n.Value));
            Console.ReadKey();
            tree.Invert();
            tree.BFS(tree, (n) => Console.WriteLine(n.Value));
            Console.ReadKey();
        }

        /// <summary>
        /// Returns a tree
        ///     A
        ///    / \
        ///   B   C
        ///  / \  / \
        /// D  E  F G
        /// 
        /// </summary>
        /// <returns></returns>
        static Tree BuildTree()
        {
            var tree = new Tree();
            var node = new Node("A", new Node("B", "D", "E"), new Node("C", "F", "G"));
            tree.Root = node;
            return tree;
        }
    }
}
