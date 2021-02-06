package uia.com.contabilidad.gestor;


public class Decorador implements IGestor {

	protected IGestor gestor;
	
	public Decorador()
	{	
		super();
	}
	
	
	public Decorador(IGestor gestor)
	{	
		super();
		this.gestor = gestor; 
	}
	
	
	@Override
	public void Print() {
		gestor.Print();		
	}

	@Override
	public void Lee() {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void Busca() {
		// TODO Auto-generated method stub
		
	}
	
}
