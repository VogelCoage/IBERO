
package proyectoauto;

import java.util.ArrayList;

public class ProyectoAuto {

    public static void main(String[] args) {
        Auto miVocho = new Auto("VW", "Sedan","Blanco",2);
        
        System.out.println(miVocho.toString());
        System.out.println(miVocho.pitar());
        System.out.println();
        Camion miCamion = new Camion("Dina", "Super Camion", "Rojo", 2, 20);
        System.out.println(miCamion.toString());
        System.out.println(miCamion.pitar());
        
    }
    
    static void EjemploAutos(){
        //Se declara la lista enlazada
        ArrayList<Auto> miLista = new ArrayList<>();
        
        //Se instancian 3 objetos de tipo Auto
        Auto miVocho = new Auto("VW", "Sedan","Blanco",2);
        Auto miFerrari;
        Auto miCarro = null;
        
        //Se inicializa la instancia miFerrari
        miFerrari = new Auto("Ferrari", "Maranello", "Rojo");
        
        System.out.println(miVocho.toString());
        System.out.println(miVocho.pitar());
        
        //Se imprimen las 3 instancias
        System.out.println(miVocho);
        System.out.println(miFerrari);
        System.out.println(miCarro);
        
        //Se mueven estas dos instancias
        miVocho.avanza(50);
        miFerrari.avanza(100);
        
        //Se imprimen para ver los cambios
        System.out.println(miVocho);
        System.out.println(miFerrari);
        
        //La instancia miCarro apunta a miVocho
        miCarro = miVocho;
        
        //Se imprime la instancia para ver que ha quedado igualado con miVocho
        System.out.println(miCarro);
        
        //Se mueve la instancia miVocho
        miVocho.avanza(100);
        
        //Se imprimen las instancias para observar los cambios
        System.out.println(miCarro);
        System.out.println(miVocho);
        
        //Ahora miCarro apunta a miFerrari
        miCarro = miFerrari;
        
        //Se imprime la instancia
        System.out.println(miCarro);
        //Se mueve y se vuelve a imprimir para observar la nueva posición
        miCarro.avanza(200);
        System.out.println(miCarro);
        
        //Se imprime el número de elementos incluidos en la lista enlazada (no hay)
        System.out.println("Número de elementos: " + miLista.size());
        
        //Se agregan tres elementos a la lista enlazada
        miLista.add(miVocho);
        miLista.add(miFerrari);
        miLista.add(new Auto("Nissan", "Tsuru", "Gris"));
        
        //Se imprime el número de elementos incluidos en la lista enlazada
        System.out.println("Número de elementos: " + miLista.size() + "\nLos elementos son: ");
        
        //El ciclo para imprimir cada elemento dentro de la lista enlazada
        for(Auto coche:miLista){
            System.out.println("\t" + coche);
        }
    }
    
}

