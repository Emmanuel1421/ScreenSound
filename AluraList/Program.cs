using AluraList;

Album album1 = new Album("album a");


Banda queen = new Banda("Queen");


queen.AdicionarAlbum(album1);
queen.ExibirDiscografia();


Musica musica1 = new Musica(queen, "musicaa")
{
    Duracao = 200,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "musicab")
{
    Duracao = 200,
    Disponivel = false,
};

musica1.ExibirFichaTecnica();

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirMusicasAlbum();

queen.AdicionarAlbum(album1);
queen.ExibirDiscografia();
Console.ReadKey();

/*
Random random = new Random();
int numeroAleatorio = random.Next(1, 99999);
double limiteAleatorio = random.Next(400, 1000);

Titular t = new();
t.Nome = "Alberto";

Conta conta1 = new Conta();
conta1.Id = "2";
conta1.Titular = t;
conta1.Agencia = 182;
conta1.NumeroConta = numeroAleatorio;
conta1.Saldo = 550.00;
conta1.Senha = 4321;
conta1.Limite = limiteAleatorio;
conta1.ApresentacaoConta();

var tst = new Teste();

int result = tst.Somar(5, 10);
Console.WriteLine(result);
Console.ReadKey(); 
*/