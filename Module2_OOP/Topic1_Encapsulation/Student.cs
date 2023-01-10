using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic1_Encapsulation
{
    internal class Student
    {
        // Encapsulation fields -> Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public bool Gender { get; set; } 

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Dob: {Dob:dd/MM/yyyy}, Gender: {(Gender == true ? "Male" : "Female")}";
        }
    }
}
