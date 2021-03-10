using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student {

    public Student(){

    }
    public int Id {get; set;}

   
    public string Name {get; set;}

    public string Address {get; set; } 

    public DateTime Dob { get; set; }
   
    
}