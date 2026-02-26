using System;
namespace jogoAtvdd;

public class Jogo
{

	public Jogo(string nome, double preco) 
	{
		Nome = nome;
		Preco = preco;
	}

	public string Nome { get; }
    public double Preco { get; }
	public string Descricao { get; set; }
	
}
public class CatalogoJogos
{
	private List<Jogo> Jogos { get; set; }

	public CatalogoJogos() 
	{
		Jogos = new List<Jogo>();
	}

	public void AdicionarJogo(string nome, double preco) 
	{
		Jogo jogoNovo = new Jogo(nome, preco);
		Jogos.Add(jogoNovo);
		Console.WriteLine($"Jogo {nome} adicionado ao catálogo.");
	}
	public void ExibirBiblioteca() 
	{
		foreach(var jogo in Jogos) 
		{
            Console.WriteLine($"Nome do Jogo: {jogo.Nome}\nDescrição do jogo: {jogo.Descricao}\nPreço do jogo: {jogo.Preco}");
        }
	}
	
}
