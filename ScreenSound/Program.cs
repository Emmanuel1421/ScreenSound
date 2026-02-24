using ScreenSound;

/*
var cb = new ContaBancaria();
cb.MostrarInformacoes();
var v = new Veiculo();
v.MenuAcao();
v.Acelerar();
v.Frear();
v.Buzinar();
*/

var song = new List<Musica>();

var m1 = new Musica();
m1.Disponivel = true;
Console.WriteLine(m1.Disponivel);
m1.Nome = "Numb";
m1.Artista = "Linkin Park";
m1.Duracao = 350;
//m1.InserirMusica();
m1.ExibirFichaTecnica();

var m2 = new Musica();
m2.Disponivel = false;
Console.WriteLine(m2.Disponivel);
m2.Nome = "The trooper";
m2.Artista = "Iron Maiden";
m2.Duracao = 280;
//m2.InserirMusica();
m2.ExibirFichaTecnica();


Console.WriteLine("Press any key to exit...");
Console.ReadKey();