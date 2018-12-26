using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesModels
{
    public class Teacher:People
    {
        public List<Discipline> ListOfDisciplines { get; }

        public Teacher(string name, string obs):base (name ,obs)
        {
            this.ListOfDisciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline disc)
        {
            if (!this.ListOfDisciplines.Contains(disc))
            {
                this.ListOfDisciplines.Add(disc);
            }
        }

        public void RemoveDiscipline(Discipline disc)
        {
            if (this.ListOfDisciplines.Contains(disc))
            {
                this.ListOfDisciplines.Remove(disc);
            }
        }

        public override void Print()
        {
            Console.WriteLine($" Teacher name: {this.Name}");
            foreach (var disc in this.ListOfDisciplines)
            {
                disc.PrintDiscipline();
            }
        }
    }
}
