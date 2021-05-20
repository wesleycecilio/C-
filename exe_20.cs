using System;
class exe_20{
	static void Main(){
		string senha = "tbgb@moi09";
		string senhauser="000";
		int tentativas=0;
		
		while (senha!=senhauser){
			Console.Clear();
			Console.WriteLine("Digite a senha do usuário:");
			senhauser=Console.ReadLine();
			
			tentativas++;
		}
			
		Console.Clear();
		Console.WriteLine("SENHA CORRETA, TENTATIVAS: {0}",tentativas);
	}
}
