using AluraList;


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




/*
Album album1 = new Album();
album1.NomeAlbum = "album a";

Musica musica1 = new Musica();
musica1.Nome = "musica a";
musica1.Duracao = 200;

Musica musica2 = new Musica();
musica2.Nome = "musica b";
musica2.Duracao = 165;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirAlbum();
*/

/*
var tst = new Teste();

int result = tst.Somar(5, 10);
Console.WriteLine(result);
Console.ReadKey(); 
*/