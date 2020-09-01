//Clase que define al objeto Nodo
using System;
namespace SimpleLinkedList
{
    public class Node
    {
        //Atributos de la clase (un valor y u nodo que apunta al nodo siguiente)
        public string value;
        public Node next;

        //Costructor de la clase
        public Node(string newValue)
        {
            value = newValue;
            next = null;
        }

        //Método que sirve para comparar el valor de nodos distintos
        public int CompareTo(Node other)
        {
            return string.Compare(value, other.value, StringComparison.Ordinal);
        }
    }
}
