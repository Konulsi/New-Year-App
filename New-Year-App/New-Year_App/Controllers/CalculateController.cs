using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_App.Controllers
{
    public class CalculateController
    {
        private readonly CalculateService _service;

        public CalculateController() => _service = new CalculateService();   
        public void Calculate()
        {

            Console.WriteLine("Reqem daxil edin");
        Number1: string num1Str = Console.ReadLine();
            int num1;
            bool IsparseNum1 = int.TryParse(num1Str, out num1);
            if (!IsparseNum1)
            {
                Console.WriteLine("Duzgun reqem daxil edin");
                goto Number1;
            }

            Console.WriteLine("Operatoru daxil edin");
            string op = Console.ReadLine();

            Console.WriteLine("Reqem daxil edin");
        Number2: string num2Str = Console.ReadLine();
            int num2;
            bool IsParsenum2 = int.TryParse(num2Str, out num2);
            if (!IsParsenum2)
            {
                Console.WriteLine("Duzgun reqem daxil edin");
                goto Number2;   
            }
            if (num2 == 0 && op == "/")
            {
                Console.WriteLine("sifira bolmek olmur");
            }

            var result = _service.Calculate(num1, num2, op);
            Console.WriteLine($"{"Netice"} {result}");


        }

    }
}
