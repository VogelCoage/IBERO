using System;
namespace DoubleLinkedList
{
    public class DoubleList
    {
        //Atributos de la clase
        private Node head;
        private Node tail;

        //Constructor
        public DoubleList()
        {
            head = null;
            tail = null;
        }

        //Método para verificar si la lista está vacía
        public Boolean IsEmpty()
        {
            return ((head == null) && (tail == null));
        }

        //Mètodos para insertar un nodo al final
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
                newNode.before = tail;
                tail = newNode;
            }
        }

        //Métodos para insertar un nodo al principio
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
                head.before = newNode;
                head = newNode;
            }
        }

        //Métodos para insertar los nodos de manera ordenada según su valor
        public void InsertOrdered(string newValue)
        {
            InsertOrdered(new Node(newValue));
        }

        private void InsertOrdered(Node newNode)
        {
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                //De acuerdo a cada compraración se decide en que lugar insertar el nodo
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
                    Node behind = head;
                    Node after;

                    while (newNode.CompareTo(behind.next) > 0)
                    {
                        behind = behind.next;
                    }
                    after = behind.next;

                    newNode.next = behind.next;
                    newNode.before = behind;
                    behind.next = newNode;
                    after.before = newNode;
                }
            }
        }

        //Método para buscar un nodo con cierto valor en la lista
        public Node SerchNode(string value)
        {
            Node myNode = null;
            for(Node current = head; current != null; current = current.next)
            {
                if(string.Compare(value, current.value, StringComparison.Ordinal) == 0)
                {
                    myNode = current;
                    break;
                }
            }
            return myNode;
        }

        //Método para borrar el primer elemento de la lista
        private void DeleteFirst()
        {
            if(head != tail)
            {
                head = head.next;
                head.before = null;
            }
            else
            {
                head = null;
                tail = null;
            }
        }

        private void DeleteLast()
        {
            if(head != tail)
            {
                tail = tail.before;
                tail.next = null;
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
                Node behind = nodeToDelete.before;
                Node after = nodeToDelete.next;

                behind.next = nodeToDelete.next;
                after.before = nodeToDelete.before;
            }
            else
            {
                head = null;
                tail = null;
            }
        }

        //Método par borrar un nodo de acuerdo a su valor
        public void Delete(string value)
        {
            if (!IsEmpty())
            {
                if(string.Compare(value, head.value, StringComparison.Ordinal) == 0)
                {
                    DeleteFirst();
                }
                else if(string.Compare(value, tail.value, StringComparison.Ordinal) == 0)
                {
                    DeleteLast();
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

        //Método para imprimir la lista
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

        //Método para imprimir en sentido contrario
        public void PrintReverse()
        {
            if (!IsEmpty())
            {
                for(Node current = tail; current != null; current = current.before)
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
                    Console.WriteLine("Este: " + current.GetHashCode().ToString()
                     + "\tValor: " + current.value + "\tAnterior: " + (current.before 
                        != null ? current.before.GetHashCode().ToString() : "null 000")
                      + "\tSiguiente: " + (current.next != null ? current.next.GetHashCode().ToString()
                         : "null 000"));
                }
            }
            else
            {
                Console.WriteLine("La lista está vacía!!!...");
            }
        }

        public void PrintVerboseReverse()
        {
            if (!IsEmpty())
            {
                for(Node current = tail; current != null; current = current.before)
                {
                    Console.WriteLine("Este: " + current.GetHashCode().ToString()
                     + "\tValor: " + current.value + "\tAnterior: " + (current.before
                         != null ? current.before.GetHashCode().ToString() : "null 000")
                      + "\tSiguiente: " + (current.next != null ? current.next.GetHashCode().ToString()
                          : "null 000"));
                }
            }
            else
            {
                Console.WriteLine("La lista está vacía!!!...");
            }
        }
    }
}






