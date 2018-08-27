using System;
using System.Collections.Generic;

namespace classes
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Amazon", new DateTime(2018, 8, 20));


            Employee Jose = new Employee()
            {
                FirstName = "Jose",
                LastName = "Ramirez",
                Title = "Manager",
                StartDate = new DateTime(2018, 3, 3),
            };
            Employee Paco = new Employee()
            {
                FirstName = "Paco",
                LastName = "Sanchez",
                Title = "Asst. Manager",
                StartDate = new DateTime(2016, 8, 8),
            };
            Employee Luis = new Employee()
            {
                FirstName = "Luis",
                LastName = "Sanchez",
                Title = "Asst. Manager",
                StartDate = new DateTime(2012, 4, 4),
            };

            // Assign the employees to the company
            myCompany.Hire(Jose);
            myCompany.Hire(Paco);
            myCompany.Hire(Luis);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            myCompany.DisplayEmployees();

        }
    }
}