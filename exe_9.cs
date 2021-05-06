using System;
class exe_9{
	static void Main(){
	Console.WriteLine("Digite dois valores, caro usuário:");
	string[] valores = Console.ReadLine().Split(' ');
	int n1 = int.Parse(valores[0]);
	int n2 = int.Parse(valores[1]);
	if (n1%n2==0 || n2%n1==0){
		Console.WriteLine("Os números são primos");
	}
	else{
		Console.WriteLine("Os números não são primos");
	}
}
}

