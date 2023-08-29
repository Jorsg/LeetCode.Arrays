using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public class DVD
	{
        public string Name { get; set; }
        public int releaseYear { get; set; }
        public string Director { get; set; }

		public DVD(string name, int releaseYear, string director)
		{
			Name = name;
			this.releaseYear = releaseYear;
			Director = director;
		}

		public string toStrinPrint()
		{
			return this.Name + ", director by" + this.Director + "releaseyear" + this.releaseYear; 
		}
	}
}
