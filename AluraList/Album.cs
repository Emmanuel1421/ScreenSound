using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraList 
{ 
    public class Album
    {
        public Album(string nome)
        {
            Nome = nome;
        }

        private List<Musica> musicas = new();

        public string Nome { get; } 

        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        

        public void ExibirMusicasAlbum() 
        {
            Console.WriteLine($"Lista de músicas do álbum: {Nome}\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Duração total do álbum: {DuracaoTotal}s");
            
        }
      
        public void ExibirDiscografia()
        {
            Console.WriteLine();
        }

    }
}
