//Clase que define al objeto lista (construida a partir de nodos)
package simplelinkedlist;

public class SimpleList {
    //Atributos de la clase sipleList (nodo inicial y nodo final)
    private Node head;
    private Node tail;
    
    //Constructor de la clase
    public SimpleList(){
        head = null;
        tail = null;
    }
    
    //Mètodo que verifica si la lista está vacía o no
    public boolean isEmpty(){
        return ((head == null) && (tail == null));
    }
    
    //Método que inserta cierto valor al final
    public void insertLast(String newValue){
        insertLast(new Node(newValue));
    }
    
    //Método que inserta un nuevo nodo al final
    private void insertLast(Node newNode){
        //Si la lista está vacía...
        if(isEmpty()){
            //El nuevo nodo será al mismo tiempo inicial y final
            head = newNode;
            tail = newNode;
        }
        //Por el contrario...
        else{
            //El nuevo nodo se asignará al nodo next del nodo final
            tail.next = newNode;
            //el nuevo nodo ahora es el nodo final
            tail = newNode;
        }
    }
    
    //Método que inserta cierto valor antes que otro
    public void insertBefore(String newValue){
        insertBefore(new Node(newValue));
    }
    
    //Método que inserta un nodo antes que otro
    private void insertBefore(Node newNode){
        //Si la lista está vacía
        if(isEmpty()){
            //l nuevo nodo será al mismo tiempo inicial y final
            head = newNode;
            tail = newNode;
        }
        //De otra manera..
        else{
            
            newNode.next = head;
            head = newNode;
        }
    }
    
    //Métodos para insertar en orden según el valor del nuevo nodo
    public void insertOrdered(String newValue){
        insertOrdered(new Node(newValue));
    }
    
    private void insertOrdered(Node newNode){
        //Se evalúa si la lista está vacía
        if(isEmpty()){
            head = newNode;
            tail = newNode;
        }
        //En caso de no estarlo, se decide donde insertar en base al valor del nodo
        else{
            //Se compara con el nodo inicial
            if(newNode.compareTo(head) < 0){
                insertBefore(newNode);
            }
            //Se hace la comparación con el nodo final
            else if(newNode.compareTo(tail) > 0){
                insertLast(newNode);
            }
            //Se hace la comparación con el resto de los nodos de la lista, recorriendola
            else{
                //Se crea un nuevo nodo que permitira recorrer la lista
                Node behind = head;
                while(newNode.compareTo(behind.next) > 0){
                    behind = behind.next;
                }
                //Al salir del ciclo se inserta el nuevo nodo en el lugar indicado según su valor
                newNode.next = behind.next;
                behind.next = newNode;
            }
        }
    }
    
    //Método para recorrer la lista de principio a fin
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
    
    //Método para borrar el primer nodo de la lista
    private void deleteFirst(){
        //Si hay más de un nodo
        if(head != tail){
            head = head.next;
        }
        //Si solo hay un nodo en la lista
        else{
            head = null;
            tail = null;
        }
    }
    
    //Mètodo para borrar el nodo del final
    private void deleteAfter(Node nodeToDelete){
        if(head != tail){
            Node behind = head;
            while(behind.next != nodeToDelete){
                behind = behind.next;
            }
            behind.next = nodeToDelete.next;
            
            if(nodeToDelete == tail){
                tail = behind;
            }
        }
        else{
            head = null;
            tail = null;
        }
    }
    
    //Método para borrar un nodo en base a su valor
    public void delete(String value){
        if(!isEmpty()){
            if(value.compareTo(head.value) == 0){
                deleteFirst();
            }
            else if(value.compareTo(tail.value) == 0){
                deleteAfter(tail);
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
    
    //Método que imprime el valor de todos los nodos incluidos en la lista
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
    
    public void printVerbose(){
        if(!isEmpty()){
            for(Node current = head; current != null; current = current.next){
                System.out.println("Este: " + Integer.toHexString(current.hashCode())
                        + "\tValor: " + current.value + "\tSiguiente: " + (current.next
                                != null ? Integer.toHexString(current.next.hashCode()):
                                "null 000"));
            }
        }
        else{
            System.out.println("La lista está vacía!!!...");
        }
    }
}














