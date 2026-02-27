
using ScreenSound.Models;
using System;
using System.Collections.Generic;

namespace ScreenSound.Models;

public class Banda
{
    private List<Album> albums = new List<Album>();
    Banda ira = new Banda("ira!")
    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}