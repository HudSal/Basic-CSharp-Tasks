using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Student : Person
    {
        private string[] _subjects;

        //TODO: 2, add constructor
        public Student(string name,string[] subjects):base(name)
        {
            _subjects = subjects;
        }

        public override void PrintDetails()
        {
            //TODO: 3, print details to console
            string strsubject = "";
            for (int i = 0; i < _subjects.Length; i++)
            {
                if (i < _subjects.Length - 1) 
                { 
                     strsubject += _subjects[i]+",";
                }
                else
                {
                    strsubject += _subjects[i];
                }
            }
            Console.WriteLine($"Hi my name is {_name} and I am studying {strsubject}");
           
        }
    }
}
