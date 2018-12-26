using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesModels
{
    public class SchoolClass:IComment
    {
        public string IDClass { get; }
        public string Observations { get; }
        public List<Teacher> ListOfTeachers { get; }
        public List<Student> ListOfStudents { get; }

        public SchoolClass(string idClass, string obs, List<Teacher> listOfTeachers, List<Student> listOfStudents)
        {
            this.IDClass = idClass;
            this.Observations = obs;
            this.ListOfTeachers = new List<Teacher>();
            this.ListOfStudents = new List<Student>();
        }

        public void AddTeacher(Teacher teacher)
        {
            if (!this.ListOfTeachers.Contains(teacher))
            {
                this.ListOfTeachers.Add(teacher);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (this.ListOfTeachers.Contains(teacher))
            {
                this.ListOfTeachers.Remove(teacher);
            }
        }

        public void AddStudent(Student student)
        {
            if (!this.ListOfStudents.Contains(student))
            {
                this.ListOfStudents.Add(student);
            }
        }

        public void RemoveStudent(Student student)
        {
            if (this.ListOfStudents.Contains(student))
            {
                this.ListOfStudents.Remove(student);
            }
        }

        public void PrintListOfTeachers()
        {
            Console.WriteLine($"Class '{this.IDClass}' has the following teachers:");
            foreach (var teach in this.ListOfTeachers)
            {
                teach.Print();
            }
        }

        public void PrintListOfStudents()
        {
            Console.WriteLine($"Class '{this.IDClass}' is attended by the following students:");
            foreach (var stud in this.ListOfStudents)
            {
                stud.Print();
            }
        }
    }
}
