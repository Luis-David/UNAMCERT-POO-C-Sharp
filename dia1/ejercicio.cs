
class ImprimeNumero{
	static void Main(){
		int num = System.Convert.toInt32(System.Console.ReadLine());

		int fac = Factorial.factorial(num);
		System.Console.WriteLine(fac);
		Systen.Console.ReadKey(true);
	}
	static public int imprimeNumeros(int n){
		if(n<101){
			Console.WriteLine(num);
			return imprimeNumeros(n+1);
		}
		else
			return 0;
			
		return n*factorial(n);
	}

}