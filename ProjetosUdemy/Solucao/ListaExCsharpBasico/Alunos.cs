using System;



namespace ListaExCsharpBasico { 
public class Aluno
{
	public string nome;
	public int B1, B2, B3 , B4, mediaIndividual;
	public Aluno(string nomeP , int b1, int b2,int b3,int b4)
	{
		this.nome = nomeP;
		this.B1 = b1;
		this.B2 = b2;
		this.B3 = b3;
		this.B4 = b4;
	}
}
}