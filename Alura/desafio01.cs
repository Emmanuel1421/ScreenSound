using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura
{
    internal class Operacoes
    {
        List<string> BandasFavoritas = new List<string> { };
        List<int> Numeros = new List<int> { 5, 10, 9, 23, 2, 3, 23, 3, 54, 2 };
        List<int> Pares = new List<int> { };
        float a = 50.00f, b = 12.25f;
        string bandas;

        public void ExecutarOperacoes()
        {
            float soma = a + b, mult = a * b, div = a / b, sub = a - b;

            Console.WriteLine($"Soma: {soma}\nSubtração: {sub}\nMultiplicação: {mult}\nDivisão: {div}\nSubtração: {sub}\n");
        }


        public void AdicionarBandas()
        {
            Console.WriteLine("Digite o nome da sua banda favorita");
            BandasFavoritas.Add(bandas = Console.ReadLine());
        }

        public void ListarBandas()
        {
            foreach (string banda in BandasFavoritas)
            {
                Console.WriteLine($"Banda: {banda}");
            }
        }

        public void SomandoLista()
        {
            int soma = 0;
            foreach (int num in Numeros)
            {
                soma += num;
                Console.WriteLine(soma);
            }
        }

        public void ListaPares()
        {
            foreach (int numero in Numeros)
            {
                if(numero % 2 == 0) 
                {
                    Pares.Add(numero);
                    Console.WriteLine($"\n{numero}");
                }
                
            }

        }


    }
}

