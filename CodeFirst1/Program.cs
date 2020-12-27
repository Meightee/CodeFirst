using CodeFirst.Data;
using CodeFirst.Data.Models;
using System;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                var student = new Student();
                student.Name = "Вася";
                student.PhoneNumber = "9777120210";
                student.RegisteredOn = DateTime.Now;

                context.Students.Add(student);

                context.Courses.Add(new Course
                {
                    Name = "EF CORE",
                    Price = 0,
                    Description = "Курс о разработке прилоложений и тд",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(30)
                });
                context.SaveChanges();
            }
        }
    }
}
