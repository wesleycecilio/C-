using System;
class exe_17{
	static void Main(){
		Console.WriteLine("Selecione qual combustivel utilizar");
		Console.WriteLine("[1] - ETANOL\n[2] - GASOLINA\n[3] - DIESEL");
		Console.WriteLine("[4] - Se desistiu de abstecer");
		int op = int.Parse(Console.ReadLine());
		int etanol=0;
		int gasolina=0;
		int diesel=0;
		
		
		while (op >=1 || op<=4){
			
			if (op==1){
			etanol = etanol+1;
			}
			else if (op==2){
			gasolina = gasolina+1;
			}
			else if (op==3){
			diesel=diesel+1;
			}
			
			{
				op = int.Parse(Console.ReadLine());
				
			}
			
		}
			Console.WriteLine("Obrigado por usar nossos serviços");
            Console.WriteLine("Alcool: " + etanol);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
		}
		
	}
