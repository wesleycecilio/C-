using System;
class exe_13{
	static void Main(){
		Console.WriteLine("Digite as coordenadas use o separador;");
		string [] valores = Console.ReadLine().Split(';');
		double x= double.Parse(valores [0]);
		double y= double.Parse(valores [1]);
		
		if (x==0&& y==0){
			Console.WriteLine("Os pontos estão na origem");
		}
		else if (x>0 && y>0){
			Console.WriteLine("O ponto está no primeiro quadrante");
		}
		else if (x>0 && y<0){
			Console.WriteLine("O ponto está no segundo quadrante");
		}
		else if(x<0&& y<0){
			Console.WriteLine("O ponto está no terceiro quadrante");
		}
		else{
			Console.WriteLine("O ponto está no quarto quadrante");
		}
	}
}
