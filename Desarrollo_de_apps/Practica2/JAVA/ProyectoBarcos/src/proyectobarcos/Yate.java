
package proyectobarcos;
/*Nueva clase Yate, hija de la clase Lancha (extends) por lo que hereda atributos e
* implementa (implements) la interface Navegacion
*/ 
public class Yate extends Lancha implements Navegacion{
    //Nuevos atributos que se agregan a los que ya hereda
    public int noCubiertas;
    public int noPasajeros;
    //Constructor por defecto (sin argumentos)
    public Yate(){
        nombre = "Yate privado";
        noVelas = 0;
        motor = "Dentro de borda";
        noCubiertas = 1;
        noPasajeros = 5;
    }
    /*Sobrecarga del constructor (con 5 argumentos), por lo que se invoca al
    * constructor de la clase padre de 3 argumentos
    */
    public Yate(String nombre, int noVelas, String motor, int noCubiertas, int noPasajeros){
        super(nombre, noVelas, motor);
        this.noCubiertas = noCubiertas;
        this.noPasajeros = noPasajeros;
    }
    //Se sobrescribe el método Avanzar, con override
    @Override
    public void avanzar(){
        System.out.println("El " + nombre + " avanza muy rápido!!!");
    }
    /*Una vez más se sobrescribe el método ToString invocando al mismo método
    * de la clase padre, pero agregando los nuevos atributos
    */    
    @Override
    public String toString(){
        return super.toString() + " | " + " No de cubiertas: " + noCubiertas + " | " +
                " No. de pasajeros: " + noPasajeros;
    }    
}
