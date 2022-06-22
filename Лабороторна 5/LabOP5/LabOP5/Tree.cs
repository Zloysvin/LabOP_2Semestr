using System;
using System.Collections.Generic;
using System.Text;

namespace LabOP5
{
    public class Tree
    {
        public Node Root;

        public Tree(string symbols)
        {
            Root = new Node(symbols[0]);
            for (int i = 1; i < symbols.Length; i++)
            {
                AddNode(symbols[i], ref Root);
            }
        }
        void AddNode(char symbol, ref Node node)
        {
            if (symbol > node.Value) 
            {
                if (node.Right == null) 
                {
                    node.Right = new Node(symbol);
                }
                else
                {
                    AddNode(symbol, ref node.Right);
                }
            }
            if (symbol < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(symbol);
                }
                else
                {
                    AddNode(symbol, ref node.Left);
                }
            }
        }
        public void FindHeight(Node node, ref int height, int i, ref bool isFound, char target)
        {
            if (!isFound)
            {
                if (node.Value != target)
                {
                    if (node.Left != null)
                    {
                        i++;
                        FindHeight(node.Left, ref height, i, ref isFound, target);
                    }
                    if (node.Right != null)
                    {
                        i++;
                        FindHeight(node.Right, ref height, i, ref isFound, target);
                    }
                }
                else
                {
                    height = i -1;
                    isFound = true;
                }
            }
            return;
        }
        private void OutTree(Node node, int level)
        {
            if (node != null)
            {
                OutTree(node.Left, level + 1);
                for (int i = 0; i < level; i++)
                {
                    Console.Write("\t");
                }
                Console.WriteLine("|----- " + node.Value);
                OutTree(node.Right, level + 1);
            }
        }
        public void OutTree()
        {
            OutTree(Root, 0);
        }
    }
}
