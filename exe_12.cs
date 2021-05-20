using System;
class exe_12{
	static void Main(){
		Console.WriteLine("Digite qualquer valor:");
		double n1=double.Parse(Console.ReadLine());
		
		if (n1>=0 && n1<25){
			Console.WriteLine("O número {0} está no intervalo [0:25]",n1);
		}
		else if (n1>=25 && n1<50){
			Console.WriteLine("O número {0} está no intervalo [25:50]",n1);
		}
		else if (n1>=50 && n1<75){
			Console.WriteLine("O número {0} está no intervalo [50:75]",n1);
		}
		else if (n1>=75 && n1<=100){
			Console.WriteLine("O número {0} está no intervalo [75:100]",n1);
		}
		else{
			Console.WriteLine("Número fora dos intervalos");
		}
	}
}