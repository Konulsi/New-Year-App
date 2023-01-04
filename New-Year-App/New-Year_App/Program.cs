
#region Task-Calculate
//1) Kalkulyator yazacaqsiniz. +,-,*,/ emeliyyatlari hesablanacaq. Service mentiqi ile.


using New_Year_App.Controllers;

//CalculateController controller = new CalculateController();
//controller.Calculate();

#endregion


#region Task-Fibonacci
//2) Fibonacci alqoritmini hesablayan method yazacaqsiniz. Service mentiqi ile.


using New_Year_App.Controllers;

//FibonacciController controller = new FibonacciController();
//controller.GetNumFibonacci();


#endregion


#region Task-Student

//3) Student classi olacaq (Domain layerde), Studentin id, name, surname, email, age, education, address propertileri olacaq.
//Ashagidaki methodlari service mentiqi ile yazacaqsiz.
//   1. Studentlerin sayini gostermek.
//   2. Studentlerin orta sayini gostermek.
//   3. Emaili c herfi ile bashlayan telebelerin siyahisini ekranda gostermek.
//   (Dinamik olmalidir, bashqa herfde gonderilse ona uygun olanlari cixarmalidir)
//   4.Addresinde Ehmedli sozu olan telebelerin siyahisini ekranda gostermek.
//   (Dinamik olmalidir, bashqa sozde gonderilse ona uygun                       olanlari cixarmalidir)
//   5.Search methodu olacaq.Name ve surname -e gore telebelerin siyahisini gostermelidir.
//   6. Adlari eyni olan telebelerin sayini ekranda gostermek.




using New_Year_App.Controllers;


StudentController controller = new StudentController();

//controller.GetCountStudents();

//controller.GetAvarageStudents();

//controller.GetStudentsEmailFiltered();

//controller.GetStudentAddress();

//controller.SearchNameAndSurname();

controller.SearchSameName();



#endregion


#region Task-Employee

//4) Employee classi olacaq (Domain layerde) . Employee classinin icinde Name, Surname, Birthday, Salary propertileri olacaq.
//Employelerin icinden metoda iki verqli tarix ve salary gelir.
//Dogum gunu hemin tarixler arasinda olan ve maashi 2000 - den boyuk olan ishcilerin sayini gosteren method yazin.




//using New_Year_App.Controllers;

//EmployeeController controller = new EmployeeController();
//controller.GetEmployeeCount();


#endregion





