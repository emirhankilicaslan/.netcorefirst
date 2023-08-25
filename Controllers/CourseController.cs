using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller{
    public IActionResult Index(){
        var course = new Course();
        
        course.Id = 1;
        course.Title = "Aspnet Kursu";
        course.Description = "Guzel bir kurs.";
        course.Image = "1.jpeg";

        return View(course);
    }
    public IActionResult Details(){
        var course = new Course();
        
        course.Id = 1;
        course.Title = "Aspnet Kursu";
        course.Description = "Guzel bir kurs.";
        course.Image = "1.jpeg";

        return View(course);
    }

    public IActionResult List(){
        return View(Repository.Courses);
    }
}