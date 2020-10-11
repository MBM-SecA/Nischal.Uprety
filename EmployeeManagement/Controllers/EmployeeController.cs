using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        
        Person emp1 = new Person(){ FirstName = "Nischal", Surname = "Uprety", Address = "jhapa", Gender = "M", Salary = 500000 };
        Person emp2 = new Person(){ FirstName = "Utsav", Surname = "Kuinkel", Address = "Kathmandu", Gender = "M", Salary = 50000 };
        Person emp3 = new Person(){ FirstName = "Shreedhar", Surname = "Pandey", Address = "Dang", Gender = "M", Salary = 5000 };
        Person emp4 = new Person(){ FirstName = "Puja", Surname = "Thapa", Address = "jhapa", Gender = "F", Salary = 150000 };
        Person emp5 = new Person(){ FirstName = "Diya", Surname = "Xetri", Address = "Kathmandu", Gender = "F", Salary = 10000 };
        Person emp6 = new Person(){ FirstName = "Arshon", Surname = "Niroula", Address = "jhapa", Gender = "M", Salary = 510000 };
        List<Person> employees = new List<Person>() { emp1,emp2,emp3,emp4,emp5,emp6 };
        return View(employees);
    }
}

