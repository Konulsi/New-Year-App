using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        int GetCountStudents();

        int GetAvarageStudents();

        Student[] GetStudentsEmailFiltered(string letter);

        Student[] GetStudentAddress(string address);

        Student[] SearchNameAndSurname(string name, string surname);

        int SearchSameName(string name);

        
        
    }
}
