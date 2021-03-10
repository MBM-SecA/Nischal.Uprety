using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee {

    public Employee(){

    }
    public int Id {get; set;}

   
    public string FirstName {get; set;}

    
    public string LastName {get; set;}

    public string Address {get; set; } 

    public char Gender { get; set; }
    public long? Contact {get; set; }

    public Department Department { get; set; }
    public int DepartmentId { get; set;}
    
}