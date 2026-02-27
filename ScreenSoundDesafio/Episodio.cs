using ScreenSoundDesafio;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace ScreenSoundDesafio
{
    public class Episodio
    {

        private List<Convidado> Convidados = new List<Convidado>();
       
        public Episodio(double duracao, int ordem, string resumo, string titulo )
        {
            Duracao = duracao;
            Ordem = ordem;
            Resumo = resumo;
            Titulo = titulo;
        }


        public double Duracao { get; set; }
        public int Ordem { get; set; }
        public string Resumo { get; set; }
        public string Titulo { get; set; }

        

        public void AdicionarConvidados(List<Convidado> pessoas)
        {
            Convidados.AddRange(pessoas);
        }

        

        public void ExibirConvidados()
        {
            foreach (var conv in Convidados)
            {
                Console.WriteLine(conv.Nome);
            }
        }

    }

}


