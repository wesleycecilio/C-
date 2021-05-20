using System;
class exe_19{
	static void Main(){
		string senha = "tbgb@moi09";
		string senhauser;
		int tentativas=0;
		do{
			Console.Clear();
			Console.WriteLine("Digite a senha do usuário:");
			senhauser=Console.ReadLine();
			tentativas++;
			}while (senha!=senhauser);
		Console.Clear();
		Console.WriteLine("SENHA CORRETA, TENTATIVAS: {0}",tentativas);
	}
}
