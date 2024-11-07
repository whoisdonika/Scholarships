using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarships
{
    public class Scholarship
    {

		
		private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		private double sum;

		public double Sum
		{
			get { return sum; }
			set { sum = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double grade;

		public double Grade
		{
			get { return grade; }
			set
			{
				if (value > 6 || value < 2)
				{
					throw new ArgumentOutOfRangeException( "Grade must be between 2 and 6");
				}
				grade = value;
				
			}
		}

		private string detentions;

		public string Detentions
		{
			get { return detentions; }
			set { detentions = value; }
		}

        public Scholarship(string type, double sum, string name, double grade, string detentions)
        {
			this.type = type;
			this.sum = sum;
			this.name = name;
			this.grade = grade;
			this.detentions = detentions;
        }

        public Scholarship(string type, double sum)
        {
            this.type = type;
            this.sum = sum;
        }

		public void PrintExample()
		{
			Console.WriteLine($"Scholarship type : {this.type} \n Scholarship sum : {this.sum}");
		}

        public void PrintAllInfo()
        {
            Console.WriteLine($"Scholarship type : {this.type} \nScholarship sum : {this.sum}" +
				$" \nStudent name : {this.name} \nStudent grade : {this.grade} \nDetentions : {this.detentions} \n---------------------");
        }

		


    }
}
