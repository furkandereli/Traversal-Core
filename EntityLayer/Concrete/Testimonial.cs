using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Testimonial
	{
		[Key]
		public int testimonialId {  get; set; }
		public string client { get; set; }
		public string comment { get; set; }
		public string clientImage { get; set; }
		public bool status { get; set; }
	}
}
