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
                new Course() {
                    Id = 1,
                    Title = "Aspnet Kursu",
                    Description = "Guzel bir kurs.",
                    Image = "1.jpeg",
                    Tags = new string[] {"aspnet", "Web gelistirme"},
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 2,
                    Title = "Python Kursu",
                    Description = "Guzel bir kurs.",
                    Image = "2.jpeg",
                    Tags = new string[] {"python", "Web gelistirme"},
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 3,
                    Title = "Angular Kursu",
                    Description = "Guzel bir kurs.",
                    Image = "3.jpeg",
                    isActive = true,
                    isHome = true
                },
                new Course() {
                    Id = 4,
                    Title = "Javascript Kursu",
                    Description = "Guzel bir kurs.",
                    Image = "1.jpeg",
                    isActive = true,
                    isHome = false
                }                
            };
        }

        public static List<Course> Courses 
        {
            get{
                return _courses;
            }
        }

        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}