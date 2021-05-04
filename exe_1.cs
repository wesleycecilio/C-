using System;
class exe_1{
	static void Main(){
		Console.Write("Digite 02 valores:");
		int x = int.Parse(Console.ReadLine());
		int y = int.Parse(Console.ReadLine());
		int s = x+y;
		Console.WriteLine("Soma = {0}",s);
	}
}