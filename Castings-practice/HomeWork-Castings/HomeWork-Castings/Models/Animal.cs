using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Castings.Models
{
    public class Animal
    {
        public string Name { get; set; }

        //public int Speed { get; set; } = 100;

        //public Animal()
        //{
        //    Console.WriteLine("Animal constructor");
        //}
        public void Test()
        {
            Console.WriteLine("Animal test");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
