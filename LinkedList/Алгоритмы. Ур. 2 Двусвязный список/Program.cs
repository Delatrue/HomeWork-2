using System;
using System.Collections;
using System.Collections.Generic;

namespace Алгоритмы._Ур._2_Двусвязный_список
{
    /* Реализовал: 
     * - int GetCount();
     * - void AddNode(int value);
     * - void RemoveNode(int index);
     * - bool FindNode(int searchValue);
     * Не реализовал:
     * - void AddNodeAfter(Node node, int value); Пробовал по аналогии с удалением - при передаче значения при выводе на консоль VS ругался, что не может преобразовать тип .Node в int
     * - void RemoveNode(Node node); здесь не понял как ноду в параметр передать
     */
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }
    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value); // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента

        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        bool FindNode(int searchValue); // ищет элемент по его значению
    }
    public class DoubleLinkedList : IEnumerable, ILinkedList
    {
        Node head; // первый элемент
        Node tail; // последний элемент
        public int count = 0; // кол-во элементов в списке

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }

        public IEnumerable BackEnumerator()
        {
            Node current = tail;
            while (current != null)
            {
                yield return current.Value;
                current = current.PrevNode;
            }
        }

        public int GetCount()
        {
            return count;
        }

        public void AddNode(int value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.NextNode = node;
                node.PrevNode = tail;
            }
            tail = node;
            count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            //не реализовано
        }
        public void RemoveNode(int index)
        {
            Node current = head;

            // поиск удаляемого узла
            while (current != null)
            {
                if (current.Value.Equals(index))
                {
                    break;
                }
                current = current.NextNode;
            }
            if (current != null)
            {
                // если узел не последний
                if (current.NextNode != null)
                {
                    current.NextNode.PrevNode = current.PrevNode;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = current.PrevNode;
                }

                // если узел не первый
                if (current.PrevNode != null)
                {
                    current.PrevNode.NextNode = current.NextNode;
                }
                else
                {
                    // если первый, переустанавливаем head
                    head = current.NextNode;
                }
                count--;
            }
        }

        public void RemoveNode(Node node)
        {
            if (node.NextNode == null)
                return;

            var nextNode = node.NextNode.NextNode;
            node.NextNode = nextNode;

        }
        public bool FindNode(int searchValue) // поиск реализован
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value.Equals(searchValue))
                    return true;
                current = current.NextNode;
            }
            return false;
        }
    }

    class Programm
    {
        static void Main(string[] args)
        {
            DoubleLinkedList linkedlist = new DoubleLinkedList();

            // добавляем элементы в конец списка
            linkedlist.AddNode(1);
            linkedlist.AddNode(2);
            linkedlist.AddNode(3);
            linkedlist.AddNode(4);
            linkedlist.AddNode(5);

            //выводим список на консоль
            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Элементов: " + linkedlist.count);

            // ищем значение 4
            Console.WriteLine("Элемент (4) в списке?: " + linkedlist.FindNode(4));

            // удаляем значение 4
            linkedlist.RemoveNode(4);

            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Элементов: " + linkedlist.count);
            // снова ищем значение 4
            Console.WriteLine("Элемент (4) в списке?: " + linkedlist.FindNode(4));

        }
    }
}