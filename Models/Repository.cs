using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository(){
            _courses = new List<Course>()
            {
                new Course() {Id = 1, Title = "Aspnet Kursu", Description = "Guzel bir kurs.", Image = "1.jpeg"},
                new Course() {Id = 2, Title = "Python Kursu", Description = "Guzel bir kurs.", Image = "2.jpeg"},
                new Course() {Id = 3, Title = "Angular Kursu", Description = "Guzel bir kurs.", Image = "3.jpeg"},
                new Course() {Id = 4, Title = "Javascript Kursu", Description = "Guzel bir kurs.", Image = "1.jpeg"}                
            };
        }

        public static List<Course> Courses 
        {
            get{
                return _courses;
            }
        }
    }
}