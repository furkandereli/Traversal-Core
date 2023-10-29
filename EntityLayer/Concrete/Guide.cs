using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Guide
	{
		[Key]
		public int guideId {  get; set; }
		public string? name { get; set;}
		public string? description { get; set;}
		public string? image {  get; set;}
		public string? description2 { get; set;}
		public bool status { get; set;}
		public List<Destination> Destinations { get; set; }
	}
}
