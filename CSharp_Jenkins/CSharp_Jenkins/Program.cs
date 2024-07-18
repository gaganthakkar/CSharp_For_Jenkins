using CSharp_Jenkins;
using System;

namespace CsharpForJenkins
{
    class CJenkins
    {
        public static void Main()
        {
            //Console.WriteLine("envirnment has been setup"); 


            //Employee employee1 = new Employee{

            //    Id = 1, 
            //    Name = "Gagan",
            //    Hobbies = new List<string> { "cricket", "badminton"}
            //}; 
            
            //Employee employee2 = new Employee{

            //    Id = 2, 
            //    Name = "Prarthana",
            //    Hobbies = new List<string> { "swimming", "badminton"}
            //};

            //List<Employee> employees = new List<Employee>
            //{
            //    employee1, 
            //    employee2
            //};

            //foreach (var item in employees)
            //{
            //        Console.WriteLine($"{item.Id}, {item.Name}");
            //    Console.WriteLine("Hobbies");

            //    foreach (var hobby in item.Hobbies)
            //    {
            //        Console.WriteLine($"{hobby}");
            //    }
            //}

            Triangle triangle = new Triangle();
            Triangle returnVal = triangle.GettingInstance(true);

            Console.WriteLine(returnVal.color);
      
        }
    }

    public class Triangle
    {
        public string color { get; set; }

        public Triangle GettingInstance(bool isBool)
        {
            Triangle returnTriangleColor;

            returnTriangleColor = new Triangle { color = "green" };

            return returnTriangleColor;
        }

    }

}