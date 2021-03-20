using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int deltaTempo;
            int deltaDistancia;
            int velocidade;

           
            Console.Write("Digite o tempo gasto em segundos..: ");
            deltaTempo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a distância percorrida em metros..: ");
            deltaDistancia = Convert.ToInt32(Console.ReadLine());
            velocidade = Convert.ToInt32((deltaDistancia) /  (deltaTempo));
            Console.Write($"Velocidade atingida..: {velocidade} m/s");
            
            
        }
    }
}
