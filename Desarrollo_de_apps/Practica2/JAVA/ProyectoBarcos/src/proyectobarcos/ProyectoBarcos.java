
package proyectobarcos;

public class ProyectoBarcos {

    public static void main(String[] args) {
        //Se instancian los objetos de tipo Barco, Lancha y Yate
        Barco navio = new Barco("SS Sotavento", 4);
        Lancha pesca = new Lancha();
        Yate yatecito = new Yate("Navegante", 0, "De turbina", 2, 10);
        
        /*Se aplican los distintos métodos que funcionan de manera particular
        * en cada objeto según la clase
        */  
        System.out.println(navio.toString());
        navio.avanzar();
        navio.girarBabor();
        navio.girarBabor();
        System.out.println("Ancla levantada: " + navio.anclar() + " | " + "El " +
                navio.nombre + " ha arribado!!!");
        System.out.println("Ancla levantada: " + navio.desanclar() + " | " + "El " +
                navio.nombre + " ha sarpado!!!");
        System.out.println();
        System.out.println(pesca.toString());
        System.out.println("Ancla levantada: " + pesca.desanclar() + " | " + "El " +
                pesca.nombre + " ha sarpado!!!");
        pesca.avanzar();
        pesca.girarEstribor();
        System.out.println("Ancla levantada: " + pesca.anclar() + " | " + "El " +
                pesca.nombre + " ha arribado!!!");
        System.out.println();
        System.out.println(yatecito.toString());
        System.out.println("Ancla levantada: " + yatecito.desanclar() + " | " + "El " +
                yatecito.nombre + " ha sarpado!!!");
        yatecito.avanzar();
        yatecito.girarBabor();
        System.out.println("Ancla levantada: " + yatecito.anclar() + " | " + "El " +
                yatecito.nombre + " ha arribado!!!");
    }
    
}
