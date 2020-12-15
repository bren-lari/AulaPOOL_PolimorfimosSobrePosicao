using System;
using Polimorfismo.Classes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            MegaMen mega = new MegaMen();

            mega.Correr();

            Zero zero = new Zero();
            
            zero.Pular();
        }
    }
}
