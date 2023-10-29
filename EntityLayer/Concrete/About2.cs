using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About2
	{
		[Key]
		public int about2Id {  get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public string image {  get; set; }

	}
}
