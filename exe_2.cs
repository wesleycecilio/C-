using System;
class exe_2{
	static void Main(){
		Console.WriteLine("Digite o raio do círculo:");
		double r = double.Parse(Console.ReadLine());
		double a = Math.Pow(r,2)*Math.PI;
		Console.WriteLine("A área é {0} ",a.ToString("F3"));
	}
}