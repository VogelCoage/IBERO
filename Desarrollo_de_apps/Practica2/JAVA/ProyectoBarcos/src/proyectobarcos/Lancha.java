package proyectobarcos;
/*Clase Lancha, hija de la clase barco (extends), heredando sus atributos y métodos
*además de implementar (implements) la interface Navegacion
*/
public class Lancha extends Barco implements Navegacion{
    //Nuevo atributo de clase
    protected String motor;
    //Constructor primario (sin argumentos)
    public Lancha(){
        nombre = "bote de pesca";
        noVelas = 0;
        motor = "Fuera de borda";
    }
    /*Sobrecarga del constructor con 3 argumentos
    *que invoca al constructor de la clase padre con 2 argumentos
    */ 
    public Lancha(String nombre, int noVelas, String motor){
        super(nombre, noVelas);
        this.motor = motor;
    }
    /*Sobrescritura del método ToString, invocando al método ToString de la
    * clase padre y agregándole el nuevo atributo
    */ 
    @Override
    public String toString(){
        return super.toString() + " | " + "Motor: " + motor;
    }
}
