using System;

namespace Polimorfismo.Classes
{
    public abstract class Player
    {
        public virtual void Correr(){
            Console.WriteLine("Correndo...");
        }

            public virtual void Pular(){
                Console.WriteLine("Pulando...");
            }
        }
    }