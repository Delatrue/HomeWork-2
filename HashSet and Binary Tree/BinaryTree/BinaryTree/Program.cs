using System;
using System.Collections.Generic;

namespace BinaryTree //22.11 - готово!
{
    public class TreeNode : IComparable
    {
        public TreeNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public int CompareTo(object obj)
        {
            return Value.CompareTo(obj);
        }
    }
    public interface ITree
    {
        TreeNode GetRoot();
        void AddItem(int value); // добавить узел - !реализовано
        void RemoveItem(int value); // удалить узел по значению - !реализовано
        TreeNode GetNodeByValue(int value); //получить узел дерева по значению - !реализовано
        void PrintTree(); //вывести дерево в консоль - !реализовано
    }
    public class Tree : ITree
    {
        public static TreeNode root;
        public void AddItem(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else
            {
                AddTo(root, value);
            }
        }
        private void AddTo(TreeNode root, int value)
        {
            if (value.CompareTo(root.Value) < 0)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = new TreeNode(value);
                }
                else
                {
                    AddTo(root.LeftChild, value);
                }
            }
            else
            {
                if(value.CompareTo(root.Value) > 0)
                {
                    if (root.RightChild == null)
                    {
                        root.RightChild = new TreeNode(value);
                    }
                    else
                    {
                        AddTo(root.RightChild, value);
                    }
                }
            }
        }
        

        public TreeNode GetNodeByValue(int value)
        {
            TreeNode current = root;
            TreeNode parent = null;
            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    parent = current;
                    current = current.LeftChild;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.RightChild;
                }
                else
                {
                    break;
                }
            }
            return current;
        }

        public TreeNode GetRoot()
        {
             return root;
        }

        public void PrintTree()
        {
            PreOrderTravers(root);
        }
        public void PreOrderTravers(TreeNode root, string space = " ")
        {
            if (root != null)
            {
                PreOrderTravers(root.RightChild, space + "\t");
                Console.WriteLine($"{space}{root.Value}");
                PreOrderTravers(root.LeftChild, space + "\t");
            }
        }

        public void RemoveItem(int value)
        {
            TreeNode current = root;
            TreeNode parent = null;
            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    parent = current;
                    current = current.LeftChild;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.RightChild;
                }
                else
                {
                    break;
                }
            }
            if(current.LeftChild == null) // если нет детей
            {
                if(current.RightChild == null)
                {
                    parent.RightChild = null;
                }
            }
            if(current.LeftChild != null) // если оба ребенка
            {
                if(current.RightChild != null)
                {
                    if(parent.Value.CompareTo(current.Value) > 0)
                    {
                        parent.LeftChild = current.LeftChild;
                        current.LeftChild.RightChild = current.RightChild;

                    }
                    else
                    {
                        parent.RightChild = current.LeftChild;
                        current.LeftChild.RightChild = current.RightChild;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            tree.AddItem(100);            
            tree.AddItem(90);
            tree.AddItem(110);
            tree.AddItem(70);
            tree.AddItem(95);
            tree.AddItem(105);
            tree.AddItem(115);

            tree.PrintTree();
            Console.WriteLine("----------------------");
            tree.RemoveItem(110);
            tree.PrintTree();
        }

    }
}
