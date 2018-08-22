using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Employed = true;
            employee.Id = 1234;

            Employee employee2 = new Employee();
            employee2.FirstName = "Ample";
            employee2.LastName = "Tudent";
            employee2.Employed = true;
            employee2.Id = 1234;

            if (employee.Id == employee2.Id)
            {
                Console.WriteLine("The two employee ID's are identical and therefore are invalid.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The two employee ID's are not identical.");
                Console.ReadLine();
            }

            //employee.Quit();
        }
    }
}
