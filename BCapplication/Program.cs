using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCapplication
{ /*
    OOP Pillars - Inheritance, Polymorphism
    Create a C# application that has an employee general class and two specialised 
    classes to represent lecturers and Admin staff
    1. Implement inheritance
    2. Implement polymorphism
    3. Calculate salary 
        a. Basic salary
        b. Basic + Commission
    4. Create list employees and display details using menu
  
   */
    internal class Program
    {
        enum Menu
        {
            Capture =1,
            Lectures,
            Admin,
            exit
        }
        static List<Employee> BCEmployees = new List<Employee>
        {
            new Lecturer{Name = "Simba", Surname = "Zengeni", EmpID = "BC20", Course ="Programming"},
            new Admin{Name = "Cecil", Surname = "Donalds",EmpID = "BC30",
            Commision = 1600.00}
        };
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.WriteLine(@"
                                    1. Capture 
                                    2. Display Lecturers 
                                    3. Display Admin
                                    4. Exit
                                  ");
                int options = int.Parse(Console.ReadLine());
                Menu select = (Menu)options;
                switch (select)
                {
                    case Menu.Capture:
                        Console.WriteLine(@"
                                    1. Lecture
                                    2. Admin");
                        Console.WriteLine("Select from above Employee to Capture");
                        int capture = int.Parse(Console.ReadLine());
                        if (capture == 1)
                        {
                            Lecturer lecturer = new Lecturer(); // Create lecturer Object
                            Console.Write("Name:");
                            lecturer.Name = Console.ReadLine();
                            Console.Write("Surname:");
                            lecturer.Surname = Console.ReadLine();
                            Console.Write("EmpID:");
                            lecturer.EmpID = Console.ReadLine();
                            Console.Write("Course:");
                            lecturer.Course = Console.ReadLine();
                            BCEmployees.Add(lecturer);
                        }

                        if (capture == 2)
                        {
                            Lecturer lecturer = new Lecturer(); // Create lecturer Object
                            Console.Write("Name:");
                            String name = Console.ReadLine();
                            Console.Write("Surname:");
                            String surname = Console.ReadLine();
                            Console.Write("EmpID:");
                            String empID = Console.ReadLine();
                            Console.Write("Commision:");
                            double commision = double.Parse(Console.ReadLine());
                            BCEmployees.Add(new Admin(name,surname,empID,commision));
                        }
                        break;
                    case Menu.Lectures:
                        foreach (var item in BCEmployees)
                        {
                            if (item is Lecturer)
                            {
                                item.calculateSalary(); //Caculate Salary
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case Menu.Admin:
                        foreach (var item in BCEmployees)
                        {
                            if (item is Admin)
                            {
                                item.calculateSalary();
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case Menu.exit:
                        exit = true;
                        break;
                    default:
                        break;
                }

            } while (exit != true);


        }
    }
}
