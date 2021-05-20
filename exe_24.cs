using System;
using System.Globalization;
namespace retangulo{
	class exe_24{
		
		static void Main(){
					
			Retangulo T = new Retangulo();
			
			Console.Write("Digite a largura em cm do retângulo:");
			T.Largura= double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);
			
			Console.Write ("Digite a altura em do retângulo:");
			T.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			Console.WriteLine();
			Console.WriteLine(T);
			
			
		}
	}
}

namespace retangulo{
	class Retangulo{
		
		public double Largura;
		public double Altura;
		
		public double Area(){
			return Largura*Altura;
		}
		public double Perimetro(){
			return 2*Largura+2*Altura;
		}
		public double Diagonal(){
			return Math.Sqrt(Math.Pow(Largura,2)+Math.Pow(Altura,2));
		}
		public override string ToString()
        {
            return "A area do retangulo é :" + Area().ToString("F2", CultureInfo.InvariantCulture) +
                  "\nO perimetro do retângulo é :" + Perimetro(). ToString("F2", CultureInfo.InvariantCulture) +
					"\nA diagonal do retângulo é :" + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
	}
}

		