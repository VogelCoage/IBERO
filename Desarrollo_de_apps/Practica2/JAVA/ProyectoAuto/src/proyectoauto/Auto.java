package proyectoauto;


public class Auto {
    //Declaración de las variables de clase
    public String marca;
    public String modelo;
    public String color;
    public int noPuertas;
    protected double kilometraje;
    protected double posicion;
    
    //Declaración del constructor
    public Auto(){
        noPuertas = 4;
        kilometraje = 0;
        posicion = 0;
    }
    
    //Sobrecargas del constructor
    public Auto(String marca, String modelo, String color){
        this(); //invoca al constructor vacìo
        this.marca = marca;
        this.modelo = modelo;
        this.color = color;
    }

    public Auto(String marca, String modelo, String color, int noPuertas){
        this(marca, modelo, color);//Invoca al constructor anterior
        this.noPuertas = noPuertas;
    }
    
    //Métodos para modificar el kilometraje y la posición
    public void avanza(double distancia){
        kilometraje += distancia;
        posicion += distancia;
    }
    
    public void retrocede(double distancia){
        kilometraje += distancia;
        posicion -= distancia;
    }
    
    //nuevo método
    public String pitar(){
        return "El " + marca + " está pitando!!!";
    }
    
    //Sobrecarga del método toSting
    @Override
    public String toString(){
        return marca + " " + modelo + " " + color + " | " + kilometraje + "km x=" + posicion;
    }
    
}
