using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Person
    {
        protected string _name;
        public Person(){}

        public Person(string name)
        {
            //TODO: 1, initialise _name field
            _name = name;

        }

        public abstract void PrintDetails(); 
    }
}
