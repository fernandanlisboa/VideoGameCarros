using System;
using System.Collections.Generic;

namespace Av1
{
    class VideoGame
    {
        static void Main(string[] args)
        {

            List<Carro> carros = new List<Carro>();

            Carro carro = new Hatch();
            carros.Add(carro);

            Carro carro0 = new Sedan();
            carros.Add(carro0);

            Carro carro1 = new SUV();
            carros.Add(carro1);

            Carro carro2 = new Sedan();
            carro2 = new ControleEletronico(carro2);
            carro2 = new FarolLED(carro2);
            carros.Add(carro2);

            Carro carro3 = new Hatch();
            carro3 = new CapotaConversivel(carro3);
            carro3 = new ControleEletronico(carro3);
            carro3 = new FreioABS(carro3);
            carros.Add(carro3);

            Carro carro4 = new SUV();
            carro4 = new MotorTurbo(carro4);
            carro4 = new MotorEletrico(carro4);
            carro4 = new ControleEletronico(carro4);
            carro4 = new FreioABS(carro4);
            carros.Add(carro4);

            Carro carro5 = new Hatch();
            carro5 = new FarolLED(carro5);
            carro5 = new MotorEletrico(carro5);
            carro5 = new FreioABS(carro5);
            carros.Add(carro5);

            Console.WriteLine("\t\tCarros!");
            foreach(Carro c in carros)
            {
                Console.WriteLine(c.getDescricao() + "\n");
                Console.WriteLine("\nR$" + c.custo());
                Console.WriteLine("-------------------------------");
            }
            
        }
    }
}
