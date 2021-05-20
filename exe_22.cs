using System;
class exe_22{
	static void Main(){
		int[] vetor1=new int[5];
		int[] vetor2=new int[5];
		int[] vetor3=new int[5];
		int[,] matriz=new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};
		Random random=new Random();
		for (int i=0;i<vetor1.Length;i++){
			vetor1[i]=random.Next(50);
		}
		Console.WriteLine("Elementos Vetor1");
	foreach (int n in vetor1){
	Console.WriteLine(n);
	}
		// public static int BinarySearch(array,valor)
	Console.WriteLine("BinarySearch");
	int procurado=33;
	int pos= Array.BinarySearch(vetor1,procurado);
	Console.WriteLine("O valor {0} está na posição {1}",procurado,pos);
	Console.WriteLine("-----------------------------------------------------");
	
	// public static void copy(Ar_origem,Ar_destino,qtde e elemento)
	Console.WriteLine("Copy");
	Array.Copy(vetor1,vetor2,vetor1.Length);
	foreach(int n in vetor2){
		Console.WriteLine(n);
		
	}
	Console.WriteLine("-----------------------------------------------------");
	// public void copy To(Ar_destino, a_partir_desta_pos)
	Console.WriteLine("Copy TO");
	vetor1.CopyTo(vetor3,0);
	foreach(int n in vetor3){
		Console.WriteLine(n);
	}
	Console.WriteLine("-----------------------------------------------------");
	
    // public long GETLongLength (dimensão)
	Console.WriteLine("GetLongLength");
	long qtdeElementosVetor=vetor1.GetLongLength(0);
	Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
	Console.WriteLine("-----------------------------------------------------");
	// public int GetLowerBound(dimensão)
	Console.WriteLine("GetLowerBound");
	int MenorIndiceVetor=vetor1.GetLowerBound(0);
	int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
	Console.WriteLine("Menor indice do vetor 1 {0}",MenorIndiceVetor);
	Console.WriteLine("-----------------------------------------------------");
	
	//public int GetupperBound(dimensão)
	Console.WriteLine("GetUpperBound");
	int MaiorIndiceVetor=vetor1.GetUpperBound(0);
	int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
	Console.WriteLine("Menor indice do vetor 1 {0}",MaiorIndiceVetor);
	Console.WriteLine("-----------------------------------------------------");
	// public object GetValue (long indice)
	Console.WriteLine("GetValue");
	int valor0=Convert.ToInt32(vetor1.GetValue(3));
	int valor1=Convert.ToInt32(matriz.GetValue(1,3));
	Console.WriteLine("O valor da posição 3 do vetor 1: {0}",valor0);
	Console.WriteLine("-----------------------------------------------------");
	// public static int IndexoF (array,valor);
	Console.WriteLine("	IndexOf");
	int indice1=Array.IndexOf(vetor1,3);
	Console.WriteLine("Indice do primeiro valor 3: {0}",indice1);
	Console.WriteLine("-----------------------------------------------------");
	// public static int LastIndexoF (array,valor);
	Console.WriteLine("	LastIndexOf");
	int indice2=Array.LastIndexOf(vetor1,3);
	Console.WriteLine("Indice do primeiro valor 3: {0}",indice2);
	Console.WriteLine("-----------------------------------------------------");
	
	// public static void reverse (array)
	Array.Reverse(vetor1);
	foreach(int n in vetor1){
		Console.WriteLine(n);
	}
	// public void Set Value(object valorr,long pos)
	
	vetor2.SetValue(99,0);
	for(int i =0;i<vetor2.Length;i++){
		vetor2.SetValue(0,i);
	}
	Console.WriteLine("Vetor 2");
	foreach (int n in vetor2){
		Console.WriteLine(n);
	}
	
	// public static void sort(array)
	Array.Sort(vetor1);
	Array.Sort(vetor2);
	Array.Sort(vetor3);
	
	Console.WriteLine("Vetor1");
	foreach(int n in vetor1){
		Console.WriteLine(n);
	}
	Console.WriteLine("\nVetor2");
	foreach(int n in vetor2){
		Console.WriteLine(n);
	}
	Console.WriteLine("\nVetor3");
	foreach(int n in vetor3){
		Console.WriteLine(n);
	}
	}
}