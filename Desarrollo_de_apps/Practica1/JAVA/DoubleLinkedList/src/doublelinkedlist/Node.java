
package doublelinkedlist;

public class Node {
    //Atributos de clase
    String value;
    Node next;
    Node before;
    
    //Constructor de la clase
    public Node(String newValue){
        value = newValue;
        next = null;
        before = null;
    }
    
    //Mètodo para comparar el valor de los nodos
    public int compareTo(Node other){
        return value.compareTo(other.value);
    }
}
