using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesModels
{
    public abstract class People:IComment
    {
        public string Observations { get; }

        public string Name { get; }

        public People(string name, string obs)
        {
            this.Name = name;
            this.Observations = obs;
        }

        public virtual void Print()
        {
            Console.WriteLine($" {this.Name}");
        }
    }
}
