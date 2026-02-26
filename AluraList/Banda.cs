using System;
namespace AluraList;

public class Banda
{
    public Banda(string nome) 
    {
        Nome = nome;
    }

    private List<Album> albums = new();

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
            System.Console.WriteLine($"Álbum: {album.Nome}({album.DuracaoTotal})");
        }
    }
}