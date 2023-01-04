using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Castings.Models
{
    internal class Eagle : Bird
    {
        public int Speed { get; set; } = 200;

        public override void Sound()
        {
            Console.WriteLine("Eagle sound");
        }

        public void Test()
        {
            Console.WriteLine("Eagle test");
        }
    }
}
