using System;
using System.Linq;

namespace Iterator
{
    /// <summary>
    /// The iterator pattern is a design pattern in which an iterator is used to traverse 
    /// a container and access the container's elements. The iterator pattern decouples 
    /// algorithms from containers.
    /// 
    /// Iterator is an object (or, in .NET, a method) that facilitates the traversal of
    /// a data structure.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //   1
            //  / \
            // 2   3

            // in-order: 213

            var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));

            var tree = new BinaryTree<int>(root);

            Console.WriteLine(string.Join(",", tree.InOrder.Select(x => x.Value)));
        }
    }
}
