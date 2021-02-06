package uia.com.contabilidad.gestor;

public class DecoradorCompras extends Decorador{
	public DecoradorCompras() {
		
	}
	
	public DecoradorCompras(IGestor gestor)
	{
		super(gestor);
	}
	
	public void RegistroCheque() {
		System.out.println("Se ha registrado el cheque");
		//super.Print();
	}
}
