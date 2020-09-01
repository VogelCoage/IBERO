
package doublelinkedlist;

public class DoubleList {
    //Atributos de la clase
    private Node head;
    private Node tail;
    
    //Constructor
    public DoubleList(){
        head = null;
        tail = null;
    }
    
    //Mètodo para validar si la lista està vacìa
    public boolean isEmpty(){
        return ((head == null) && (tail == null));
    }
    
    //Mètodos para insertar un nodo al final
    public void insertLast(String newValue){
        insertLast(new Node(newValue));
    }
    
    private void insertLast(Node newNode){
        if(isEmpty()){
            head = newNode;
            tail = newNode;
        }
        else{
            tail.next = newNode;
            newNode.before = tail;
            tail = newNode;
        }
    }
    
    //Mètodos para insertar un nodo al principio
    public void insertBefore(String newValue){
        insertBefore(new Node(newValue));
    }
    
    private void insertBefore(Node newNode){
        if(isEmpty()){
            head = newNode;
            tail = newNode;
        }
        else{
            newNode.next = head;
            head.before = newNode;
            head = newNode;
        }
    }
    
    //Mètodos para insertar un nodo en orden según su valor
    public void insertOrdered(String newValue){
        insertOrdered(new Node(newValue));
    }
    
    private void insertOrdered(Node newNode){
        if(isEmpty()){
            head = newNode;
            tail = newNode;
        }
        else{
            if(newNode.compareTo(head) < 0){
                insertBefore(newNode);
            }
            else if(newNode.compareTo(tail) > 0){
                insertLast(newNode);
            }
            else{
                Node behind = head;
                Node after;
                
                while(newNode.compareTo(behind.next) > 0){
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
    
    //Mètodos para buscar un nodo por su valor
    public Node serchNode(String value){
        Node myNode = null;
        for(Node current = head; current != null; current = current.next){
            if(value.compareTo(current.value) == 0){
                myNode = current;
                break;
            }
        }
        return myNode;
    }
    
    //Método para borrar el primer nodo
    private void deleteFirst(){
        if(head != tail){
            head = head.next;
            head.before = null;
        }
        else{
            head = null;
            tail = null;
        }
    }
    
    //Método para borrar el último nodo
    private void deleteLast(){
        if(head != tail){
            tail = tail.before;
            tail.next = null;
        }
        else{
            head = null;
            tail = null;
        }
    }
    
    //Método para borrar nodo con cierto valor
    private void deleteAfter(Node nodeToDelete){
        if(head != tail){
            Node behind = nodeToDelete.before;
            Node after = nodeToDelete.next;
            
            behind.next = nodeToDelete.next;
            after.before = nodeToDelete.before;
        }
        else{
            head = null;
            tail = null;
        }
    }
    
    //Método para borrar un nodo en base a la comparación de su valor
    public void delete(String value){
        if(!isEmpty()){
            if(value.compareTo(head.value) == 0){
                deleteFirst();
            }
            else if(value.compareTo(tail.value) == 0){
                deleteLast();
            }
            else{
                Node nodeToDelete = serchNode(value);
                
                if(nodeToDelete != null){
                    deleteAfter(nodeToDelete);
                }
                else{
                    System.out.println("El valor no está en la lista!!!...");
                }
            }
        }
        else{
            System.out.println("La lista está vacía!!!...");
        }
    }
    
    //Método para imprimir la lista
    public void print(){
        if(!isEmpty()){
            for(Node current = head; current != null; current = current.next){
                System.out.println(current.value);
            }
        }
        else{
            System.out.println("La lista está vacía!!!...");
        }
    }
    
    //Método para imprimir la lista en orden inverso
    public void printReverse(){
        if(!isEmpty()){
            for(Node current = tail; current != null; current = current.before){
                System.out.println(current.value);
            }
        }
        else{
            System.out.println("La lista está vacía!!!...");
        }
    }
    
    public void printVerbose(){
        if(!isEmpty()){
            for(Node current = head; current != null; current = current.next){
                System.out.println("Este: " + Integer.toHexString(current.hashCode())
                        + "\tValor: " + current.value + "\tAnterior: " + (current.before
                                != null ? Integer.toHexString(current.before.hashCode()):
                        "null 000") + "\tSiguiente: " + (current.next
                                != null ? Integer.toHexString(current.next.hashCode()):
                                "null 000"));
            }
        }
        else{
            System.out.println("La lista está vacía!!!...");
        }
    }
    
    public void printVerboseReverse(){
        if(!isEmpty()){
            for(Node current = tail; current != null; current = current.before){
                System.out.println("Este: " + Integer.toHexString(current.hashCode())
                        + "\tValor: " + current.value + "\tAnterior: " + (current.before
                                != null ? Integer.toHexString(current.before.hashCode()):
                        "null 000") + "\tSiguiente: " + (current.next
                                != null ? Integer.toHexString(current.next.hashCode()):
                                "null 000"));
            }
        }
        else{
            System.out.println("La lista está vacía!!!...");
        }
    }
}












