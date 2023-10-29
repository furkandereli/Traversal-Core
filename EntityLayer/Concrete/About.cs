using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About
	{
		[Key]
		public int aboutId { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public string image1 {  get; set; }
		public string title2 { get; set; }
		public string description2 { get; set; }
		public bool status { get; set; }
	}
}
