using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.Filmes;

public class Filme
{
    public Filme(string titulo, double duracao, List<Artista> elenco) 
    {
        Titulo = titulo;
        Duracao = duracao;
        Elenco = elenco;
    }
    public string Titulo { get; set; }
    public double Duracao { get; set; }
    public List<Artista> Elenco { get; set; }


    public void AdicionarFilme() 
    {
        Console.WriteLine($"Digite o titulo do filme");
        Titulo = Console.ReadLine();
        Console.WriteLine($"Informe a duração do filme");
        Duracao = double.Parse(Console.ReadLine());
    }

    public void ExibirInfoFilme() 
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Duração: {Duracao}");

        Console.WriteLine($"Elenco: ");
        foreach(var ator in Elenco) 
        {
            Console.WriteLine(ator); 
        }
    }

    public void AdicionarElenco(Artista artista) 
    {
        Elenco.Add(artista);
    }
}



