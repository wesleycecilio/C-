using System;
using System.Globalization;
namespace aprende{
	class exe_18{
	static void Main(){
		
		triangulo x,y;
		x = new triangulo();
		y = new triangulo();
		
		Console.WriteLine("Digite as medidas do lado do triangulo X:");
		x.A= double.Parse(Console.ReadLine());
		x.B= double.Parse(Console.ReadLine());
		x.C= double.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite as medidas do lado do triangulo Y:");
		y.A= double.Parse(Console.ReadLine());
		y.B= double.Parse(Console.ReadLine());
		y.C= double.Parse(Console.ReadLine());
		
		double p = (x.A+x.B+x.C)/2;
		double areax = Math.Sqrt(p*(p-x.A)*(p-x.B)*(p-x.C));
		p = (y.A +y.B+y.C)/2;
		double areay = Math.Sqrt(p1*(p-y.A)*(p-y.B)*(p-y.C));
		Console.WriteLine("Área x :{0}\n Área y : {1}",areax,areay);
		if(areax> areay){
			Console.WriteLine("O trinâgulo X é maior");
		}
		else{
			Console.WriteLine ("O triângulo Y é maior");
		}
		
		
		/*Console.WriteLine("Digite os lados do triângulo X:");
		string[] x = Console.ReadLine().Split(';');
		double x1 = double.Parse(x[0]);
		double x2 = double.Parse(x[1]);
		double x3 = double.Parse(x[2]);
		
		Console.WriteLine("Digite os lados do triângulo Y:");
		string[] y = Console.ReadLine().Split(';');
		double y1 = double.Parse(y[0]);
		double y2 = double.Parse(y[1]);
		double y3 = double.Parse(y[2]);
		
		double p = (x1+x2+x3)/2;
		double areax = Math.Sqrt(p*(p-x1)*(p-x2)*(p-x3));
		
		double p1 = (y1+y2+y3)/2;
		double areay = Math.Sqrt(p1*(p1-y1)*(p1-y2)*(p1-y3));
		if(p >= p1){
			Console.WriteLine("O trinâgulo X é maior");
		}
		else{
			Console.WriteLine ("O triângulo Y é maior");
		}*/
		
	}

	}
}

