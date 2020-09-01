
package proyectopersona;

import java.util.Scanner;

public class ProyectoPersona {

    public static void main(String[] args) {
        String nombre;
        int edad;
        double estatura;
        boolean status;
        Scanner scan = new Scanner(System.in);
        
        /*Nota: despuès de ingresar un dato que no es cadena, el compilador ignora
        *el "enter" por lo que se debe agregar un scan.NextLine() para que fluya 
        *normalmente.
        */
        
        System.out.println("Ingresa tu edad: ");
        edad = scan.nextInt(); //Lee un entero
        scan.nextLine();
        System.out.println("Ingresa tu nombre: ");
        nombre = scan.nextLine(); //Lee una cadena
        System.out.println("Ingresa tu estatura: ");
        estatura = scan.nextDouble(); //Lee un dato double
        System.out.println("Ingresa tu status: ");
        status = scan.nextBoolean(); //Lee un booleano
        //Línea para hacer una pausa en el programa y esperar un Enter para finalizar
        scan.nextLine(); 
        
        System.out.println(nombre + " " + edad + " " + estatura + " " + status);
        
        
        scan.nextLine();
    }
    
}
