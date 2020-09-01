//Nueva clase
package proyectoauto;

public class Camion extends Auto{ //hereda de la clase Auto
    public int noPasajeros;
    
    public Camion(){
        super();//Se invoca el constructor de la clase padre (Auto)
        noPasajeros = 0;
        
        /*kilometraje = 0; //se cambia la variable de Auto de private a protected
        *para tener acceso a ella solo las clases hijas, podrá acceder a ese atributo
        */
    }
    
    public Camion(String marca, String modelo, String color, int noPuertas, int noPasajeros){
        super(marca, modelo, color, noPuertas);
        this.noPasajeros = noPasajeros;
    }
    
    //Sobreescribiendo el método
    @Override
    public String pitar(){
        return "El camión está pitando";
    }
    
    //Sobreescribiendo el método
    @Override
    public String toString(){
        return super.toString() + " " + "No. Pasajeros: " + noPasajeros;
    }
    
}
