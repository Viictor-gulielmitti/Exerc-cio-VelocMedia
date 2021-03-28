using System;

namespace Exerc_cio_VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
          Double Distancia, Tempo, Velocidade;

          Console.WriteLine("coloque um numero da distancia, em metros, que o carro percorrera até chegar em Mongagua");
          Distancia = Convert.ToDouble(Console.ReadLine()); 

          Console.ReadLine();

          Console.WriteLine("Digite o tempo, em segundos, que o carro demorou para chegar em mongagua");
          Tempo = Convert.ToDouble(Console.ReadLine());

          Velocidade = Distancia / Tempo;    

          Console.WriteLine($"A velocidade normal do carro é:{Velocidade}"); 

          




        }
    }
}
