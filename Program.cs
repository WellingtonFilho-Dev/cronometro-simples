using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.WriteLine("S = segundos => 10s = 10 segundos");
            Console.WriteLine("M = minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1,1)); //pegar o ultimo caracter
            int time = int.Parse(data.Substring(0,data.Length -1));
            int multplier = 1;

            if (type == 'm')
                multplier = 60;

            if (time == '0')
                System.Environment.Exit(0);

            PreStart(time * multplier);

            Console.WriteLine(type);
            Console.WriteLine(time);

            
        }

        static void PreStart(int time) {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);

        }

        static void Start(int time) {
             
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
