using DomainLayer.Models;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceLayer.Services
{
    public class StudentService : IStudentService
    {


        public int GetCountStudents()
        {
            Student[] students = GetAll();
            int count = 0;
            foreach (Student item in students)
            {
                count++;
            }
            return count;

        }



        public int GetAvarageStudents()
        {
            Student [] students = GetAll();
            int result = 0;  
            foreach (Student item in students)
            {
               result+= item.Age;
            }
            return result /students.Length;

            
        }



    

        public Student[] GetStudentsEmailFiltered(string letter)
        {
            Student[] students = GetAll();

            Student[] result = new Student[students.Length];

            int count = 0;
            bool check = false;
            foreach (Student item in students)
            {
                if (item.Email.ToLower().ToString().StartsWith(letter.ToLower()))
                {
                    result[count] = item;
                    count++;
                    check= true;
                }
            }
            if (!check)
            {
                Console.WriteLine(Error.ErrorEmail);
            }
            return result;
            

        }




        public Student[] GetStudentAddress(string address)
        {
            Student[] students= GetAll();

            Student[] result = new Student[students.Length];

            int count = 0;
            bool check = false; 

            foreach (Student item in students)
            {
                if (item.Address.ToLower().ToString().Contains(address.ToLower()))
                {
                    result[count] = item;
                    count++; 
                    check= true;    
                }
            }
            if (!check)
            {
                Console.WriteLine(Error.ErrorAddress);  
            }
            
            return result;

        }



        public Student[] SearchNameAndSurname(string name, string surname)
        {
            Student[] students = GetAll();
            Student[] result = new Student[students.Length];
            int count= 0;  
            bool check = false; 

            foreach (Student item in students)
            {
                if (item.Name.ToLower() == name.ToLower() && item.Surname.ToLower()  == surname.ToLower())
                {
                    result[count] = item;
                    count++;    
                    check= true;    
                }
            }
            if (!check)
            {
                Console.WriteLine(Error.ErrorFullName);  
            }
           return result;

        }






        public int SearchSameName(string name)
        {
            int count = 0;

            foreach (Student item in GetAll())
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    count++;
                }

            }
            return count;
           
        }




        private Student[] GetAll()
        {
            Student Stu1 = new Student()
            {
                Id = 1,
                Name = "Konul",
                Surname = "Ibrahimova",
                Email = "konulsi@code.edu.az",
                Age = 26,
                Education = "Bachelor",
                Address = "Sedmoy",
            };

            Student Stu2 = new Student()
            {
                Id = 2,
                Name = "Chinara",
                Surname = "Ibadova",
                Email = "chinara@code.edu.az",
                Age = 22,
                Education = "Bachelor",
                Address = "Lokbatan",
            };

            Student Stu3 = new Student()
            {
                Id = 3,
                Name = "Shaig",
                Surname = "Kazimov",
                Email = "kazimov@code.edu.az",
                Age = 25,
                Education = "Bachelor",
                Address = "Sedmoy",
            };

            Student Stu4 = new Student()
            {
                Id = 4,
                Name = "Alekber",
                Surname = "Hesenov",
                Email = "hesenov@code.edu.az",
                Age = 20,
                Education = "Bachelor",
                Address = "Bayil",
            };

            Student Stu5 = new Student()
            {
                Id = 5,
                Name = "Javid",
                Surname = "Ismayilzadeh",
                Email = "javid@code.edu.az",
                Age = 22,
                Education = "Bachelor",
                Address = "Sulutepe",
            };

            Student Stu6 = new Student()
            {
                Id = 6,
                Name = "Konul",
                Surname = "Ismayilzadeh",
                Email = "konul@code.edu.az",
                Age = 29,
                Education = "Bachelor",
                Address = "Genclik",

            };

            Student[] students = { Stu1, Stu2, Stu3, Stu4, Stu5, Stu6};
            return students;
        }

     

     
    }

    
}
