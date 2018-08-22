using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloadingExercise
{
    class Employee : Person, IQuittable
    {

        public int Id { get; set; }

        public override void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine($"Name: {fullName}");
            Console.ReadLine();
        }

        public static bool operator == (Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
            {
                
                return true;
            }
            else
            { 
                return false;
            }
       
        }
        public static bool operator != (Employee employee, Employee employee2)
        {
            if (employee.Id != employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void Quit()
        {
            if (Employed == false)
            {
                string fullName = FirstName + " " + LastName;
                Console.WriteLine(fullName + " is no longer employed.");
                Console.ReadLine();
            }


        }
    }
}
