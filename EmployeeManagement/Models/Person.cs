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
    public Department department { get; set; }
    public int DepartmentId { get; set; }


    
    
}