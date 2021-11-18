using System;
using System.Collections.Generic;

namespace BinaryTree //19.11 - в процессе доработки
{
    public class TreeNode
    {
        public TreeNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; } // ключ узла
        public TreeNode LeftChild { get; set; } // указатель на левого потомка  
        public TreeNode RightChild { get; set; } // указатель на правого потомка
        public TreeNode Parent { get; set; } // указатель на предка


        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;

            if (node == null)
                return false;

            return node.Value == Value;
        }

        public static implicit operator TreeNode(int v)
        {
            throw new NotImplementedException();
        }
    }

    public interface ITree
    {
        TreeNode GetRoot();
        void AddItem(int value); // добавить узел
        void RemoveItem(int value); // удалить узел по значению
        TreeNode GetNodeByValue(int value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль
    }
    public class Tree : ITree
    {
        public TreeNode Root { get; set; }
        public void AddItem(int value)
        {
            while(Root != null)
            {
                if(value > Root.Value)
                {
                    if(Root.RightChild != null)
                    {
                        Root = Root.RightChild;
                    }
                    else
                    {
                        Root.Parent = Root;
                        Root.RightChild = value;
                    }
                    break;
                }
                else if(value < Root.Value)
                {
                    if(Root.LeftChild != null)
                    {
                        Root = Root.LeftChild;
                    }
                    else
                    {
                        value = Root.Value;
                        Root.LeftChild = value;
                    }
                }
                break;
            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            Node search(x : Node, k: T):
                if x == null or k == x.key
                return x
                if k < x.key
                return search(x.left, k)
                    else
                return search(x.right, k)
        }

        public TreeNode GetRoot()
        {
            return Root;
        }

        public void PrintTree()
        {
            if(
            /*func preorderTraversal(x : Node)
                if x != null
                print x.key
                preorderTraversal(x.left)
                preorderTraversal(x.right)*/
        }

        public void RemoveItem(int value)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            
        }
    }
}
