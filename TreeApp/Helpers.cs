using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace TreeApp
{
    class Helpers
    {
        internal static ITreeService<int> Service = TreeService.Get<int>();

        internal static void ShowTree(Tree<int> tree)
        {
            foreach(var item in Service.Traverse(tree))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Tree is binary sorting tree: {Service.IsSearchTree(tree)}");
        }

        internal static Tree<int> GenerateTree()
        {
            var rnd = new Random();
            var root = Helpers.Service.Create(rnd.Next(100));
            var list = new List<Tree<int>>() { root };
            for(var i = 0; i < 30; i++)
            {
                Tree<int> node;
                do
                {
                    node = list[rnd.Next(list.Count)];
                }
                while (node.Left != null && node.Right != null);

                Position pos;
                if (node.Left != null && node.Right != null)
                {
                    pos = rnd.Next(2) == 1 ? Position.Left : Position.Right;
                }
                else if (node.Left == null)
                {
                    pos = Position.Left;
                }
                else
                {
                    pos = Position.Right;
                }

                list.Add(Service.Append(node, pos, rnd.Next(100)));
            }

            return root;
        }
    }
}
