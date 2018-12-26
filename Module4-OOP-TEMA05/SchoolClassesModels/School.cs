using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesModels
{
    public class School
    {
        public string NameOfSchool { get; }

        public List<SchoolClass> ListOfClasses { get; }

        public School(string name, List<SchoolClass> listOfClasses)
        {
            this.NameOfSchool = name;
            this.ListOfClasses = new List<SchoolClass>();
        }

        public void AddClass(SchoolClass schoolClass)
        {
            if (!this.ListOfClasses.Contains(schoolClass))
            {
                this.ListOfClasses.Add(schoolClass);
            }
        }

        public void RemoveClass(SchoolClass schoolClass)
        {
            if (this.ListOfClasses.Contains(schoolClass))
            {
                this.ListOfClasses.Remove(schoolClass);
            }
        }

        public void PrintSchool()
        {
            Console.WriteLine($" School named {this.NameOfSchool} owns the following classes:");
            foreach (var scClass in this.ListOfClasses)
            {
                scClass.PrintListOfTeachers();
                scClass.PrintListOfStudents();
            }

        }
    }
}
