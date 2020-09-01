
package sumaenteros;

import java.util.Scanner;

public class SumaEnteros {

    public static void main(String[] args) {
        //Declaración de variables
        int num1, num2, suma;
        String linea = new String();
        //Declaración de la instancia de tipo Scanner para el ingreso de datos
        Scanner entrada = new Scanner(System.in);
        
        System.out.println("SUMA DE DOS ENTEROS");
        
        //Se pide el primer entero
        System.out.println("Ingresa un número: ");
        linea = entrada.next();//Se asinga a la variable de tipo cadena
        num1 = Integer.parseInt(linea); //Casting del String a entero
        
        /*Nota: no es necesario realmente hacer el cast del dato si se utiliza el
        *método nextInteger() para la instancia de entrada.        */
       
        //Se pide el otro entero
        System.out.println("Ingresa otro número");
        num2 = Integer.parseInt(entrada.next());//Casting desde el ingreso del dato
        
        //Se realiza la operación
        suma = num1 + num2;
        
        //Se imprime el resultado, concatenando texto y variable
        System.out.println("La suma es: " + suma);
    }
    
}
