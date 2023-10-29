using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Newsletter
	{
		[Key]
		public int newsletterId {  get; set; }
		public string email { get; set; }
	}
}
