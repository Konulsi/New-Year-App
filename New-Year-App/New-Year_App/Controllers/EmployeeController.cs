using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_App.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _service;

        public EmployeeController()
        {
            _service = new EmployeeService();
        }

        public void GetEmployeeCount() => Console.WriteLine(_service.GetEmployeeCount(new DateTime(1990, 01, 12), new DateTime(2000, 12, 19), 1500));
    }
}
