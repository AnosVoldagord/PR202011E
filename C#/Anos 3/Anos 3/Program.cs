using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anos_3
{
    class Program
    {
        
    }
    abstract class Animals
    {
        public void Eat()
        {
            Console.WriteLine("Every Animals Eats Foodn In Order To Serve");
        }
        public abstract void AnimalsSound();
    }
      class Lion:Animals
    {
        public override void AnimalsSound()
        {
            Console.WriteLine("Lion Roars");
        }
        static void Main(string[] args)
        {
            Lion objLion = new Lion();
            objLion.AnimalsSound();
            objLion.Eat();
        }
    }
    

}

