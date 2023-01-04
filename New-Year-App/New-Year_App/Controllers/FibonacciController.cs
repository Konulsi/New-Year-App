using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_App.Controllers
{
    public class FibonacciController
    {
        private readonly FibonacciService _service;

        public FibonacciController() =>  _service = new FibonacciService();

        public void GetNumFibonacci()
        {
            Console.WriteLine("Uzunlugu teyin edin");
            Back:  string lengthStr = Console.ReadLine();
            int length;
            bool IsParseLengthStr = int.TryParse(lengthStr, out length);
            if (!IsParseLengthStr)
            {
                Console.WriteLine("Duzgun reqem daxil edin");
                lengthStr = Console.ReadLine();
                goto Back;
            }
            var result = _service.GetNumFibonacci(length);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
