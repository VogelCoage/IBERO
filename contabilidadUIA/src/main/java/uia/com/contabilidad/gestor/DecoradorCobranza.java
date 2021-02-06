package uia.com.contabilidad.gestor;

public class DecoradorCobranza extends Decorador {
	
	public DecoradorCobranza(IGestor gestor)
	{
		super(gestor);
	}
	
	
	public DecoradorCobranza()
	{		
	}
	
	public void validaCobranza()
	{
		super.Print();
	}

}
