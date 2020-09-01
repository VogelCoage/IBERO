//Clase que define el objeto SimpleList
using System;
namespace SimpleLinkedList
{
    public class SimpleList
    {
        //Atributos de la clase (un nodo que apunta al inicio y otro al final)
        private Node head;
        private Node tail;

        //Constructor de la clase
        public SimpleList()
        {
            head = null;
            tail = null;
        }

        //Método para verificar si la lista está vacía
        public Boolean IsEmpty()
        {
            return ((head == null) && (tail == null));
        }

        //Métodos para insertar un nodo al final
        public void InsertLast(string newValue)
        {
            InsertLast(new Node(newValue));
        }

        private void InsertLast(Node newNode)
        {
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        //Métodos para insertar un nodo al inicio
        public void InsertBefore(string newValue)
        {
            InsertBefore(new Node(newValue));
        }

        private void InsertBefore(Node newNode)
        {
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        //Métodos para isertar nodos de manera ordenada (según su valor)
        public void InsertOrdered(string newValue)
        {
            InsertOrdered(new Node(newValue));
        }

        private void InsertOrdered(Node newNode)
        {
            //Se valida si la lista está o no vacía
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                //Si no está vacía, se comparan los valores del nuevo nodo y de acuerdo a ello se decide donde insertarlo
                if(newNode.CompareTo(head) < 0)
                {
                    InsertBefore(newNode);
                }
                else if(newNode.CompareTo(tail) > 0)
                {
                    InsertLast(newNode);
                }
                else
                {
                    //Se crea un nuevo nodo para recorrer toda la lista en caso de ser necesario
                    Node behind = head;
                    while(newNode.CompareTo(behind.next) > 0)
                    {
                        behind = behind.next;
                    }
                    newNode.next = behind.next;
                    behind.next = newNode;
                }
            }
        }

        public Node SerchNode(string value)
        {
            Node myNode = null;
            for(Node current = head; current != null; current = current.next)
            {
                if(value.CompareTo(current.value) == 0)
                {
                    myNode = current;
                    break;
                }
            }
            return myNode;
        }

        private void DeleteFirst()
        {
            if(head != tail)
            {
                head = head.next;
            }
            else
            {
                head = null;
                tail = null;
            }
        }

        private void DeleteAfter(Node nodeToDelete)
        {
            if(head != tail)
            {
                Node behind = head;
                while(behind.next != nodeToDelete)
                {
                    behind = behind.next;
                }
                behind.next = nodeToDelete.next;
                if(nodeToDelete == tail)
                {
                    tail = behind;
                }
            }
            else
            {
                head = null;
                tail = null;
            }
        }

        public void Delete(string value)
        {
            if (!IsEmpty())
            {
                if(value.CompareTo(head.value) == 0)
                {
                    DeleteFirst();
                }
                else if(value.CompareTo(tail.value) == 0)
                {
                    DeleteAfter(tail);
                }
                else
                {
                    Node nodeToDelete = SerchNode(value);
                    if(nodeToDelete != null)
                    {
                        DeleteAfter(nodeToDelete);
                    }
                    else
                    {
                        Console.WriteLine("El valor no está en la lista!!!...");
                    }
                }
            }
            else
            {
                Console.WriteLine("La lista está vacía!!!...");
            }
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                for(Node current = head; current != null; current = current.next)
                {
                    Console.WriteLine(current.value);
                }
            }
            else
            {
                Console.WriteLine("La lista está vacía!!!...");
            }
        }

        public void PrintVerbose()
        {
            if (!IsEmpty())
            {
                for(Node current = head; current != null; current = current.next)
                {
                    Console.WriteLine("Este: " + current.GetHashCode().ToString() +
                     "\tValor: " + current.value + "\tSiguiente: " + (current.next 
                        != null ? current.GetHashCode().ToString(): "null 000"));
                }
            }
            else
            {
                Console.WriteLine("La lista está vacía!!!...");
            }
        }
    }
}
