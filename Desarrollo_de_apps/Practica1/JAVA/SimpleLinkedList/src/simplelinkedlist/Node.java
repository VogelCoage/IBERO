//Clase que define al objeto Nodo
package simplelinkedlist;

//La clase implementa los mètodos de la interface Comparable<Node>
public class Node implements Comparable<Node>{
    //Atributos de la clase (un valor y u nodo que apunta al nodo siguiente)
    String value;
    Node next;
    
    //Costructor de la clase
    public Node(String newValue){
        value = newValue;
        next = null;
    }
    
    //Método sobrecargado que sirve para comparar el valor de nodos distintos
    @Override
    public int compareTo(Node other){
        return value.compareTo(other.value);
    }
}
