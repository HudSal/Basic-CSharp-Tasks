using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Teacher : Person
    {
        private string _faculty;

        //TODO: 4, add constructor
        public Teacher(string name , string faculty):base(name)
        {
            _faculty = faculty;
        }

        public override void PrintDetails()
        {
            //TODO: 5, print details to console
            Console.WriteLine($"Hi my name is {_name} and I teach in the {_faculty} faculty");

        }
    }
}
