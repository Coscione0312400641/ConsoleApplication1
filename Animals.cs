using System;

namespace ConsoleApplication1
{
    class Animale
    {
        public virtual void FaiVerso()
        {
            Console.WriteLine("L'animale fa un verso.");
        }
    }

    class Gatto : Animale
    {
        public override void FaiVerso()
        {
            Console.WriteLine("Miao!");
        }
    }

    class Cane : Animale
    {
        public override void FaiVerso()
        {
            Console.WriteLine("Bau!");
        }
    }
}