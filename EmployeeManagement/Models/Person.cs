using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    [Required]
    [Display(Name="First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name="Last Name")]
    public string Surname { get; set; } 
    public int Id { get; set; }
    public string Address { get; set; }
    public double? Salary { get; set; }
    public char? Gender { get; set; } = 'M';
    
    public static List<Person> GetEmployees()
    {
        Person emp1 = new Person()
        {
            FirstName = "Nischal",
            Surname = "Uprety",
            Address = "Jhapa",
            Salary = 100000.0
        }; 
        Person emp2 = new Person()
        {
            FirstName = "Ram",
            Surname = "Thapa",
            Address = "Morang",
            Salary = 100000.0
        }; 
        Person emp3 = new Person()
        {
            FirstName = "Utsav",
            Surname = "Kuinkel",
            Address = "Kathmandu",
            Salary = 100000.0
        }; 
        Person emp4 = new Person()
        {
            FirstName = "Shreedhar",
            Surname = "Pandey",
            Address = "Dang",
            Salary = 100000.0
        }; 

        List<Person> employees = new List<Person> {emp1,emp2,emp3,emp4};
        return employees;
    }
}