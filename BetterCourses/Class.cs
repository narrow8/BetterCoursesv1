using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCourses
{
    class Class
    {
		public Person[] students { get; set; }

		public Class(Person[] students)
		{
			this.students = students;
		}

		public Double getFocus()
        {
            double sum = 0;
			foreach(Person person in students)
			{
				sum += person.getAttention()?1:0;
                Console.WriteLine(sum);
            }
			return sum/students.Length;
		}
		
		public Boolean isFocused()
		{
			return getFocus() >= 0.5 ? true : false;
		}



	}
}
