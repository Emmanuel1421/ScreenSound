using ScreenSoundDesafio;

public class Program
{
    public static void Main(string[] args)
    {
        List<Episodio> episodiosCriados = new List<Episodio>();
        List<Convidado> convidadosAdicionados = new List<Convidado>();

        int qtdConv;
        int i = 0;

        Podcast podc = new();
        Convidado host = new();

        Console.WriteLine("Digite o nome do Podcast");
        podc.NomePodcast = Console.ReadLine();
        Console.WriteLine("Digite o nome do host:");
        host.Nome = Console.ReadLine();

        Console.WriteLine("Quantos episodios o podcast tem?");
        int qtdEp = int.Parse(Console.ReadLine());
        for (int j = 0; j < qtdEp; j++)
        {
            Console.Write("Digite o título do episódio:");
            string titulo = Console.ReadLine();
            Console.Write("Digite o resumo do episódio:");
            string resumo = Console.ReadLine();
            Console.Write("Digite o ordem do episódio:");
            int ordem = int.Parse(Console.ReadLine());
            Console.Write("Digite o duracao do episódio:");
            double duracao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos episodios o episodio tem?");
            qtdConv = int.Parse(Console.ReadLine());
            for (i = 0; i < qtdConv; i++) 
            {
                Console.Write("Digite o nome do convidado:");
                string nome = Console.ReadLine();

                Convidado novoConv = new ();
                novoConv.Nome = nome;

                convidadosAdicionados.Add(novoConv);

            }


            Episodio novoEp = new Episodio(duracao, ordem, resumo, titulo);
            episodiosCriados.Add(novoEp);

        }
        podc.AdicionarEpisodios(episodiosCriados);

        podc.ExibirDetalhes();


        foreach (var epAtual in podc.Episodios)
        {
            Console.WriteLine($"\nEpisódio {epAtual.Ordem}: {epAtual.Titulo} ({epAtual.Duracao} min)");
            Console.WriteLine($"Resumo: {epAtual.Resumo}");
            Console.WriteLine("Convidados:");
            epAtual.ExibirConvidados();
        }
    }
}

