using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloadingExercise
{
    abstract class Person
    {
        public List<string> Persons { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Employed { get; set; }



        public abstract void SayName();
    }
}
