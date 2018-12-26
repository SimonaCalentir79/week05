using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesModels
{
    public class Discipline : IComment
    {
        public string Name { get; }

        public int NumberOfLectures { get; }

        public int NumberOfExercises { get; }

        public string Observations { get; }

        public Discipline(string name, int noOfLectures, int noOfExercises, string obs)
        {
            this.Name = name;
            this.NumberOfLectures = noOfLectures;
            this.NumberOfExercises = noOfExercises;
            this.Observations = obs;
        }

        public void PrintDiscipline()
        {
            Console.WriteLine($" Discipline: {this.Name} -- Lecture no.: {this.NumberOfLectures} -- Exercises no.: {this.NumberOfExercises}");
            Console.WriteLine($" Observations: {this.Observations}");
        }
    }
}
