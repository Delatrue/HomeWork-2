using System;
using System.Collections;
using System.Collections.Generic;

namespace BFS_DFS_tree
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
    public class Tree
    {

        public TreeNode root { get; set; }
        int count;
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
            count++;
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
                if (value.CompareTo(root.Value) > 0)
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
            if (current.LeftChild == null) // если нет детей
            {
                if (current.RightChild == null)
                {
                    parent.RightChild = null;
                }
            }
            if (current.LeftChild != null) // если оба ребенка
            {
                if (current.RightChild != null)
                {
                    if (parent.Value.CompareTo(current.Value) > 0)
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
        public static void BFS(TreeNode root, int value)
        {
            Console.WriteLine("BFS");
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root); //1
            int step = 0;
            while (queue.Count > 0) //2
            {
                root = queue.Dequeue(); //3
                step++;
                if (root.Value == value) //4
                {
                    return;
                }
                Console.WriteLine($"Шаг {step} " + root.Value + " ");

                if (root.LeftChild != null) //5
                {
                    queue.Enqueue(root.LeftChild);
                }
                if (root.RightChild != null) //5
                {
                    queue.Enqueue(root.RightChild);
                }
            }
        }
        public static void DFS(TreeNode root, int value)
        {
            Console.WriteLine("DFS");
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root); //1
            int step = 0;
            while (stack.Count > 0) //2
            {
                step++;
                root = stack.Pop(); //3
                if (root.Value == value) //4
                {
                    return;
                }
                Console.WriteLine($"Шаг {step} " + root.Value + " ");
                if (root.RightChild != null)
                {
                    stack.Push(root.RightChild); //5
                }
                if (root.LeftChild != null)
                {
                    stack.Push(root.LeftChild); //5
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

            Tree.BFS(tree.GetRoot(), 115);
            Console.WriteLine();
            Tree.DFS(tree.GetRoot(), 115);
        }
    }
}
