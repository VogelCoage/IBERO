using System;
namespace DoubleLinkedList
{
    public class Node
    {
        //Atributos de clase
        public string value;
        public Node next;
        public Node before;

        //Constructor de la clase
        public Node(string newValue)
        {
            value = newValue;
            next = null;
            before = null;
        }

        //Método para la comparación de los valores de los nodos
        public int CompareTo(Node other)
        {
            return string.Compare(value, other.value, StringComparison.Ordinal);
        }
    }
}
