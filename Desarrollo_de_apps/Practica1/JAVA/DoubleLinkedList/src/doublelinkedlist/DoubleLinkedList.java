
package doublelinkedlist;

public class DoubleLinkedList {

    public static void main(String[] args) {
        //Se declara la instancia del objeto DoubleList
        DoubleList myList = new DoubleList();
        
        //Se insertan nodos a la lista
        myList.insertOrdered("Ana");
        myList.insertOrdered("Pedro");
        myList.insertOrdered("María");
        myList.insertOrdered("Ernesto");
        myList.insertOrdered("Orlando");
        myList.insertOrdered("Cecilia");
        
        //Se imprime la lista
        System.out.println("Imprimiendo la lista...");
        myList.print();
        System.out.println();
        
        //Se imprime la lista en orden inverso
        System.out.println("Imprimiendo la lista en orden inverso...");
        myList.printReverse();
        System.out.println();
        
        myList.delete("María");
        myList.delete("Pedro");
        myList.delete("Ana");
        
        //Se imprime la lista
        System.out.println("Imprimiendo la lista...");
        myList.print();
        System.out.println();
        
        //Se imprime la lista en orden inverso
        System.out.println("Imprimiendo la lista en orden inverso...");
        myList.printReverse();
        System.out.println();
    }
    
}
