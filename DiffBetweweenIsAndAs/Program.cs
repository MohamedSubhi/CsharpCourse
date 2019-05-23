﻿using System;

namespace DiffBetweweenIsAndAs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee
            //{
            //    ID = 101,
            //    name = "Mark"
            //};

            Employee emp = new PermenetEmployee
            {
                ID = 101,
                name = "Mark"
            };

            //Employee emp = new PermenetEmployee
            //{
            //    ID = 101,
            //    name = "Mark"
            //};

            //if ( emp is Employee)
            //{
            //    Console.WriteLine(emp.name + "is employee");

            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine(emp.name + "is not employee");

            //    Console.ReadKey();
            //}

            //if (emp is PermenetEmployee)
            //{
            //    Console.WriteLine(emp.name + "is PermenetEmployee");

            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine(emp.name + "is not PermenetEmployee");

            //    Console.ReadKey();
            //}

            //if (emp is ContractEmployee)
            //{
            //    Console.WriteLine(emp.name + "is ContractEmployee");

            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine(emp.name + "is not ContractEmployee");

            //    Console.ReadKey();
            //}

            PermenetEmployee permenetEmployee = emp as PermenetEmployee;

            if (permenetEmployee == null)
                Console.WriteLine("permenetEmployee is null");
            else
                Console.WriteLine("permenetEmployee is not null");

            ContractEmployee contractEmployee = emp as ContractEmployee;

            if (contractEmployee == null)
                Console.WriteLine("contractEmployee is null");
            else
                Console.WriteLine("contractEmployee is not null");
        }

        class Employee
        {
            public int ID { get; set; }
            public string name { get; set; }
        }

        class PermenetEmployee : Employee
        {
            public int AnnualSalary { get; set; }
        }
        class ContractEmployee : Employee
        {
            public int HourlySalary { get; set; }
        }
    }
}
