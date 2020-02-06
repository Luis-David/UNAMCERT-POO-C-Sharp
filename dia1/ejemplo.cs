//using System; // De esta forma se importa los paquetes al incorporar el modulo System ya no es necesario poner
//System a cada llamado de sus funciones estaticas
class Factorial{
	static void Main(){
		//metodos estaticos son aquello que se puden llamar sin instanciar una clase, no pertenece a ningun objeto.
		//C# es de tipado fuerte 
		//tipado estático es aquel, que en tiempo de ejecucion no se pude cambiar el tipo de dato de una variable
		int num = System.Convert.ToInt32(System.Console.ReadLine());

		int fac = Factorial.factorial(num);
		System.Console.WriteLine(fac);
		System.Console.ReadKey(true);
	}
	//public pude ser accedido por cualquiera
	//interna los metodos son accedidos por herencia
	//privado solo la clase puede acceder al metodo
	static public int factorial(int n){
		if(n==1)
			return 1;
		return n*factorial(n-1);
	}
	//compilar csc ej1.c

}
//paradigma  es la forma en la que se piensa en programar para solucionar un problema o necesidad

//Pilares de la POO
/*
	herencia
	poliformismo
		Son las distintas formas que se llaman a un metodo y realiza distincas cosas
	abstraccion
		Se obtiene solo las cosas que interesan para un situacion
	encapsulacion
		Se restringir el acceso a las funciones internas de un clase


	Errores
		Sintaxis
		Error de lógica


	Metodo constructor
		Es un método que se manda a llamar al crear un objeto
		no regresa nada
		se llama igual que la clase
		es publico
	Sobre carga de metodos

	Si no se pone public a los atributos por defecto lo toma privado
*/