using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    class ContaBancaria
    {
        private string id;
        private string titular;
        private double saldo;
        private int senha;

        public string Id { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public int Senha { get; set; }

        public void In()
        {


            Console.WriteLine($"O titular da conta é {this.titular} e o saldo é {this.saldo}");
        }
    }
}   

    /*
    class Veiculo 
    {

        double velocidade = 0.5;
        double aceleracao = 0.1;
        
        int resposta;
        

        
        public void MenuAcao() 
        {
            Console.WriteLine("Digite a opção desejada:\n1.Acelerar \n2.Frear \n3.Buzinar \n");
            resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    Acelerar();
                    break;
                case 2:
                    Frear();
                    break;
                case 3:
                    Buzinar();
                    break;
                default:
                    Console.WriteLine("Selecione uma opção válida.");
                    break;
            }

            }
        

        public void Acelerar() 
        {
            if(velocidade == 0) 
            { velocidade++; }
            for (aceleracao = 1.0;aceleracao < 2.0; velocidade *= aceleracao) 
            {
                
                aceleracao++;
                Console.WriteLine($"{velocidade}Km/h");
                
            }
            MenuAcao();
        }

        public void Frear()
        {
            if (velocidade <= 0)
            {
                return;
            }
            double deceleration = 3.0;
            while (velocidade > 0)
            {
                velocidade = Math.Max(0, velocidade - deceleration);
                Console.WriteLine($"{velocidade} Km/h");
            }
            MenuAcao();
        }

        public void Buzinar() 
        {
            Console.WriteLine("bi-bi");
            MenuAcao();
        }
    }
}
    */

