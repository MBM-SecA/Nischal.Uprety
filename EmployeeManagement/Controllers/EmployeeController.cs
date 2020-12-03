using System.Linq;
using Microsoft.AspNetCore.Mvc;
 
public class EmployeeController: Controller
{
    private readonly EMSContext db;
 
    public EmployeeController(EMSContext _db)
   {
        db = _db;
    }
     
    public ActionResult Index()
    {
        
        var employees = db.People.ToList();
        return View(employees);
    }
    public ActionResult Detail([FromQuery]int id)
    {  
       var  employees = Person.GetEmployees();
        Person employee= employees.FirstOrDefault(x=>x.Id==id);
        return View(employee);
        
    }
 
    public ActionResult Add()
    {
        return View();
    }
[HttpPost]
    public ActionResult<string> Add([FromForm]Person person)
    {
        return "Employee Added successfully!!!";
    }
 
}

 