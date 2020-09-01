
package simplelinkedlist;

public class SimpleLinkedList {

    public static void main(String[] args) {
        //Se instancia un objeto de tipo lista
        SimpleList myList = new SimpleList();
        
        //Se imprime el contenido de la lista (está vacía)
        System.out.println("Imprimiendo la lista...");
        myList.print();
        System.out.println();
        
        //Se ingresan nodos a la lista de manera ordenada
        myList.insertOrdered("Daniela");
        myList.insertOrdered("Andrew");
        myList.insertOrdered("Nicolas");
        myList.insertOrdered("Emiliano");
        myList.insertOrdered("Ricardo");
        myList.insertOrdered("Ale");
        myList.insertOrdered("Karlita");
        myList.insertOrdered("Regina");
        myList.insertOrdered("Andrea");
        myList.insertOrdered("Oliver");
        myList.insertOrdered("Bety");
        myList.insertOrdered("Alex");
        
        //Se imprime el contenido de la lista
        System.out.println("Imprimiendo la lista...");
        myList.print();
        System.out.println();
        
        //Se borran cuatro nodos de la lista
        myList.delete("Ale");
        myList.delete("Ricardo");
        myList.delete("Karlita");
        myList.delete("Omar");
        
        //Se imprime el contenido de la lista
        System.out.println("Imprimiendo la lista...");
        myList.print();
        System.out.println();
    }
    
}
