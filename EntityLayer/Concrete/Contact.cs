using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Contact
	{
		[Key]
		public int contactId { get; set; }
		public string description { get; set; }
		public string email { get; set; }
		public string adress { get; set; }
		public string phone { get; set; }
		public string mapLocation { get; set; }
		public bool status { get; set; }
	}
}
