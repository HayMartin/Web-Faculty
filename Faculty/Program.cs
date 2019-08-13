using Faculty.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Faculty
{
    class Program
    {
        static void Main(string[] args)
        {
            FacultyContectFactory db = new FacultyContectFactory();
            FacultyContext context = db.CreateDbContext(null);

            




            Console.ReadKey();
        }

        public static void Add_Data(FacultyContext context)
        {
            Student student = new Student { Lastname = "Hayrapetyan", FirstName = "Martin", Age = 25 };

            context.Students.Add(student);
            context.SaveChanges();
           

        }
        public static void Read_Data(FacultyContext context)
        {
            List<Student> students = context.Students.ToList();

            foreach (var item in students)
            {
                Console.WriteLine($" ID : {item.StudentID}\nLastName :{item.Lastname}\nFirstName : {item.FirstName}\nAge : {item.Age} ");
            }
        }

        public static void Delete_Data(FacultyContext context)
        {
            Student student = context.Students.LastOrDefault();

            context.Students.Remove(student);

            context.SaveChanges();
        }

        public static void Update_Data(FacultyContext context)
        {

            Student student = context.Students.AsNoTracking().FirstOrDefault();

            student.FirstName = "Armen";
            student.Lastname = "Hovhannisyan";

            context.Students.Update(student);

            context.SaveChanges();

        }



    }
}
