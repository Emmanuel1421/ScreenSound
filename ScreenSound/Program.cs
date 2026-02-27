namespace ScreenSound.Models;


Banda ira = new Banda("Ira!");
ira.AdicionarNota(10);
ira.AdicionarNota(8);
ira.AdicionarNota(6);
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistrada.Add(ira.Nome, ira);


public class Program
{
    private static void Main(string[] args)
    { 

        Banda queen = new Banda("Queen");

         Album albumDoQueen = new Album("A night at the opera");

         Musica musica1 = new Musica(queen, "Love of my life")
         {
             Duracao = 213,
             Disponivel = true,
         };

         Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
         {
             Duracao = 354,
             Disponivel = false,
         };

         albumDoQueen.AdicionarMusica(musica1);
         albumDoQueen.AdicionarMusica(musica2);
         queen.AdicionarAlbum(albumDoQueen);

         musica1.ExibirFichaTecnica();
         musica2.ExibirFichaTecnica();
         albumDoQueen.ExibirMusicasDoAlbum();
         queen.ExibirDiscografia();



    }
    void RegistrarBanda() 
    {

        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda]
            Console.Write($"Qual a nota que a banda{nomeDaBanda} merece:");
            int nota = int.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda{nomeDaBanda}/");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        }
    }
    void ExibirDetalhes() 
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.WriteLine("Diggite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ConstainsKey(nomeDaBanda)) 
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}