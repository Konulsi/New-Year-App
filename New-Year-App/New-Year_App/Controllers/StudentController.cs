using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_App.Controllers
{
    public class StudentController
    {
        private readonly IStudentService _service;
        public StudentController()
        {
            _service = new StudentService();
        }


        public void GetCountStudents() => Console.WriteLine(_service.GetCountStudents());

        public void GetAvarageStudents() => Console.WriteLine(_service.GetAvarageStudents());

        public void GetStudentsEmailFiltered()
        {
            Console.WriteLine("Herf daxil edin");
            string letter = Console.ReadLine(); 

            Student[] result = _service.GetStudentsEmailFiltered(letter);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Email} {item.Address} {item.Education}");
                }
            }

        }

        public void GetStudentAddress()
        {
            Console.WriteLine("Unvan daxil edin");
            string address = Console.ReadLine();    
           Student[] result = _service.GetStudentAddress(address);

            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Email} {item.Address} {item.Education}");
                }
            }
        }



        public void SearchNameAndSurname()
        {
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine("Soyad daxil edin");
            string surname = Console.ReadLine();

            Student[] result = _service.SearchNameAndSurname(name,surname);
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Email} {item.Address} {item.Education}");
                }
            }


        }


        public void SearchSameName()
        {
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine($"{_service.SearchSameName(name)}");
        }


        
      





    }
}
