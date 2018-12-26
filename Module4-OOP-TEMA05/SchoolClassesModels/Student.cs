using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesModels
{
    public class Student:People
    {
        public int ID { get; }

        public Student(int id, string name, string obs):base(name,obs)
        {
            this.ID = id;
        }

        public override void Print()
        {
            Console.WriteLine($"Student ID: {this.ID} -- name: {this.Name} -- obs: {this.Observations}");
        }
    }
}
