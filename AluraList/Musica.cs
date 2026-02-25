using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraList
{
    public class Musica
    {

    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";


    public void ExibirFichaTecnica() 
    {
        Console.Clear();
        Console.WriteLine($"Nome: {this.Nome}\nArtista: {this.Artista}\nDuração: {this.Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível.");
        } else
        {
            Console.WriteLine("Adquira o plano premium");
        }

    }

    public void InserirMusica() 
    {
        Console.Clear();
        
        string resposta;

        Console.WriteLine("Digite o nome da música:");
        this.Nome = Console.ReadLine();

        Console.WriteLine("Digite o nome do artista:");
        this.Artista = Console.ReadLine();

        Console.WriteLine("Digite a duração da música:");
        this.Duracao = int.Parse(Console.ReadLine());

      
    }
    

}

}

