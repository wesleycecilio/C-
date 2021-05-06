using System;
class exe_7{
	static void Main(){
		Console.WriteLine("Caro usuário digite um valor:");
		int n1 = int.Parse(Console.ReadLine());
		if (n1<0){
			Console.WriteLine("Número negativo.");
		}
		else{
			Console.WriteLine("Número positivo.");
		}
	}
}