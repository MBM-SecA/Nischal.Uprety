using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class StateController: Controller
{
    public ViewResult First()
    {
        // StateManagement is of two types
        //1. Client Side
        //1.1 Cookies
        var name = "Nischal Uprety";
        
        Response.Cookies.Append("user",name);

        //2. Server Side
        //2.1 Session
        HttpContext.Session.SetString("Address","Jhapa");

        return View();
        
    }

    public ViewResult Second(string name, int age) //1.2 Query Strings (Query Parameters)
    {
        HttpContext.Session.GetString("Address");

        //2.2 Temp data
        TempData["CollegeName"] = "MBM College";

        return View();
    }
    [HttpPost]
    public bool Second( string collegeName) //1.3 hidden fields
    {
        return true;
    }
    public ViewResult Third() 
    {
        var cName = TempData["CollegeName"];
        byte value = 67;

        ViewData["Name1"] = "abc from Viewdata";
        ViewBag.Name = "abc from Viewbag";
        return View(value);
    }

    
}