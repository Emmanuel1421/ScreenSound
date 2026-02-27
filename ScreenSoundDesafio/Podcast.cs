using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenSoundDesafio
{
    public class Podcast
    {
        public List<Episodio> Episodios = new();

        public Convidado Host { get; set; }  
        public string NomePodcast { get; set; }
        public int TotalEpisodios;

        public void AdicionarEpisodios(List<Episodio> episodios)
        {
            Episodios.AddRange(episodios);
        }
        public void ExibirDetalhes() 
        {
            Console.WriteLine($"Nome do Host:{Host.Nome}");
            Console.WriteLine($"Nome do Podcast:{NomePodcast}");
            Console.WriteLine($"Total episodios:{TotalEpisodios = Episodios.Count}"); 
        }
    }
}

