using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Scholarship example = new Scholarship("academic", 35);
                example.PrintExample();

                Console.WriteLine("--------------------------");

                List<Scholarship> studentList = new List<Scholarship>();
                List<Scholarship> goodGrades = new List<Scholarship>();

                Console.Write("How many students would you like to add? - ");
                int n = int.Parse(Console.ReadLine());


                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter all the information :  ");
                    string[] input = Console.ReadLine().Split(' ');

                    Scholarship scholarship = new Scholarship(input[0], double.Parse(input[1]), input[2], double.Parse(input[3]), input[4]);
                    studentList.Add(scholarship);

                    if (double.Parse(input[3]) > 4.5)
                    {
                        goodGrades.Add(scholarship);
                    }


                    Console.WriteLine("------------------------");
                }


                Console.WriteLine("All students : ");
                foreach (Scholarship student in studentList)
                {
                    student.PrintAllInfo();
                }

                Console.WriteLine("All students with grades above 4,50 : ");
                foreach (Scholarship student in goodGrades)
                {
                    student.PrintAllInfo();
                }

                Console.WriteLine("Student with the highest grade : ");
                studentList.OrderByDescending(x => x.Grade);
                studentList[0].PrintAllInfo();

                Console.WriteLine("Students sorted by name (ascending) : ");
                studentList.OrderBy(x => x.Name);

                foreach (Scholarship student in studentList)
                {
                    student.PrintAllInfo();
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}
