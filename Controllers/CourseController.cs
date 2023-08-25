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

    public IActionResult List(){

        var courses = new List<Course>(){
            new Course() {Id = 1, Title = "Aspnet Kursu", Description = "Guzel bir kurs.", Image = "1.jpeg"},
            new Course() {Id = 2, Title = "Python Kursu", Description = "Guzel bir kurs.", Image = "2.jpeg"},
            new Course() {Id = 3, Title = "Angular Kursu", Description = "Guzel bir kurs.", Image = "3.jpeg"}
        };

        return View(courses);
    }
}