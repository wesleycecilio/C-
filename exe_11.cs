using System;
class exe_11{
	static void Main(){
		Console.WriteLine("Sejam bem vindos ao HAMBURGUELÂNDIA\nPor favor escolha seu pedido no menu abaixo:");
		Console.WriteLine("[1] --> Cachorro Quente --> R$ 4,00.\n[2] --> X-salada --> R$ 4,50.\n[3] --> X-bacon --> R$ 5,00.\n[4] --> Torrada Simples --> R$ 2,00\n[5] --> Refigerante --> R$ 1,50.");
		int i=0;
		int n1 = int.Parse(Console.ReadLine());
								
					if (n1==1){
						Console.WriteLine("Você escolheu, o cachorro quente, digite agora qual a quantidade do lanche");
						int n2 = int.Parse (Console.ReadLine());
						double cq=n2*4.00;
						Console.WriteLine("Total a pagar:{0}",cq.ToString("C2"));
					}
					else if (n1==2){
						Console.WriteLine("Você escolheu, o X-salada, digite agora qual a quantidade do lanche");
						int n3 = int.Parse (Console.ReadLine());
						double xs=n3*4.50;
						Console.WriteLine("Total a pagar:{0}",xs.ToString("C2"));
					}
					else if (n1==3){
						Console.WriteLine("Você escolheu, o X-bacon, digite agora qual a quantidade do lanche");
						int n4 = int.Parse (Console.ReadLine());
						double xb=n4*5.00;
						Console.WriteLine("Total a pagar:{0}",xb.ToString("C2"));
					}
					else if (n1==4){
						Console.WriteLine("Você escolheu, a torrada simples, digite agora qual a quantidade do lanche");
						int n5 = int.Parse (Console.ReadLine());
						double t=n5*2.00;
						Console.WriteLine("Total a pagar:{0}",t.ToString("C2"));
					}
					else if (n1==5){
						Console.WriteLine("Você escolheu, o refrigerante, digite agora qual a quantidade do lanche");
						int n6 = int.Parse (Console.ReadLine());
						double r=n6*1.50;
						Console.WriteLine("Total a pagar:{0}",r.ToString("C2"));
					}
					else{
					Console.WriteLine("Obrigado");
			
		
		}
	}
}
