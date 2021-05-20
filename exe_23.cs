using System;
using System.Globalization;


namespace estoque{
class exe_23{
		static void Main(){
			Produto p = new Produto();
			Console.WriteLine("Informe os dados do produto:");
			
			Console.Write("Nome:");
			p.Nome=Console.ReadLine();
			
			Console.Write("Preço:");
			p.Preco=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			
			Console.Write("Quantidade");
			p.Quantidade=int.Parse(Console.ReadLine());
			
			Console.WriteLine("Dados do produto:" + p);
			
			int op;
			
			Console.WriteLine();
            Console.WriteLine("Para alterar a quantidade do estoque:\n[1] Adicionar;\n[2] Retirar\n[3] Não realizar alterações");
            op = int.Parse(Console.ReadLine());
			
			if (op==1){
				Console.WriteLine();
                Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
				int qte=int.Parse(Console.ReadLine());
				p.AdicionarProduto(qte);
				Console.Write("Dados atualizados:" + p);
				Console.Clear();
			}
			else if(op==2){
				Console.WriteLine();
                Console.Write("Digite o número de produtos a ser retirado do estoque:");
				int qte=int.Parse(Console.ReadLine());
				p.RetirarProduto(qte);
				Console.Write("Dados atualizados:" + p);
				Console.Clear();
			}
			else if (op==3){
				Console.WriteLine("Obrigado por usar nossos serviços");
				Console.Clear();
			}
			
		}
	}
}

namespace estoque{
	class Produto{
		public string Nome;
		public double Preco;
		public int Quantidade;
		
		public double ValorTotalEmEstoque(){
		return Quantidade*Preco;
		}
		
		public int AdicionarProduto(int quantidade){
		return	Quantidade+=quantidade;
		}
		
		public int RetirarProduto(int quantidade){
		return	Quantidade-=quantidade;
		}
		public override string ToString()
        {
            return Nome +
                ", $" +
                Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
	}
}