
internal class ScreenSound
{
    public void ExibirMensagemBoasVindas()
    {
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
        Console.WriteLine("Bem vindo ao Screen Sound\n");
    }

    public static Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

    public void AdicionarBanda()
    {
        Console.Clear();
        var notas = new List<int>();
        int nota = 0;
        int opc;

        ExibirTituloOpcao("Digite o nome da Banda:");
        string nomeBanda = Console.ReadLine();
        Console.WriteLine($"\nA banda {nomeBanda} foi registrada.");
        Thread.Sleep(1000);

        Console.WriteLine("Deseja avaliar Banda? \n1.Sim 2.Não");
        opc = int.Parse(Console.ReadLine());
        if (opc == 1)
            do
            {
                Console.WriteLine("Digite as notas: ");
                nota = int.Parse(Console.ReadLine());
                if (nota != -1)
                {
                    notas.Add(nota);
                }
                ;
            } while (nota != -1);
        else if (opc == 2)
        {
            bandasRegistradas.Add(nomeBanda, notas);
            Console.Clear();
            ExibirFuncoesMenu();
        }
    }
    public void ExibirFuncoesMenu()
    {
        Console.WriteLine("1.Registrar Bandas\n2.Mostrar Bandas\n3.Atualizar Bandas\n4.Excluir Banda\n0.Sair");
        Console.WriteLine("Digite a opção desejada:");
        int opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1:
                AdicionarBanda();
                break;
            case 2:
                MostrarBandas();
                break;
            case 3:
                AvaliarBanda();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Digite uma opção válida");
                break;
        }
    }
    
    
    public void MostrarBandas()
    {
        ExibirTituloOpcao("Todos os nomes de bandas registrados:");
        foreach (var KeyValuePair in bandasRegistradas)
        {
            string nome = KeyValuePair.Key;
            List<int> notas = KeyValuePair.Value;
            string notasTexto = notas.Count > 0 ? string.Join(", ", notas) : "sem notas";
            Console.WriteLine($"Banda: {nome} \n Notas: {notasTexto}");
    };
        Console.WriteLine("\nPressione uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirFuncoesMenu();
    }

    public void AvaliarBanda() 
    {
        Console.Clear();
        ExibirTituloOpcao("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeBanda)) 
        {
            Console.Write($"Digite a nota que a banda {nomeBanda} merece: ");
            int nota = int.Parse(Console.ReadLine());
            bandasRegistradas[nomeBanda].Add(nota);
            Thread.Sleep(1000);
            Console.Clear();
            ExibirFuncoesMenu();
        } else
        {
            Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
            Console.WriteLine("\nPressione uma tecla para voltar ao menu");
            Console.ReadKey();
            ExibirFuncoesMenu();
        }
    }

    public void ExibirTituloOpcao(string titulo) 
    {
        int qtdLetras = titulo.Length;
        string hifen = string.Empty.PadLeft(qtdLetras,'-');
        Console.WriteLine(hifen);
        Console.WriteLine(titulo);
        Console.WriteLine(hifen);

    }
}