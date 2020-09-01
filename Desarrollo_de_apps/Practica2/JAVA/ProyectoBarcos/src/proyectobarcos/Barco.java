package proyectobarcos;
//Clase principal que implementa la interface Navegación
public class Barco implements Navegacion{
    //Atributos de la clase
    String nombre;
    int noVelas;
    boolean ancla;
    //Constructor primario (sin argumentos)
    public Barco(){
        nombre = "Sin nombre";
        noVelas = 2;
    }
    //Constructor sobrecargado (con 2 argumentos)
    public Barco(String nombre, int noVelas){
        //this();
        this.nombre = nombre;
        this.noVelas = noVelas;
    }
    //Métodos sobrescritos y propios de la interface
    @Override
    public void avanzar() {
        System.out.println("El " + nombre + " está avanzando");
    }

    @Override
    public void girarEstribor() {
        System.out.println("El " + nombre + " gira a estribor");
    }

    @Override
    public void girarBabor() {
        System.out.println("El " + nombre + " gira a babor");
    }

    @Override
    public boolean anclar() {
        ancla = false;
        return ancla;
    }

    @Override
    public boolean desanclar() {
        ancla = true;
        return ancla;
    }
    //Sobreescritura del método ToString
    @Override
    public String toString() {
        return "Nombre: " + nombre + " | " + "No. de velas: " + noVelas;
    }
}







