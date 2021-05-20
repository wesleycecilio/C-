using System;
class exe_15{
	static void Main(){
		Console.WriteLine("Digite a senha:");
		int n1=int.Parse(Console.ReadLine());
		
		while(n1!=2021){
			Console.WriteLine("Acesso negado");
			
			Console.WriteLine("Digite a senha:");
			n1=int.Parse(Console.ReadLine());
		}
			
		
		Console.WriteLine("Acesso autorizado!");
	}
}