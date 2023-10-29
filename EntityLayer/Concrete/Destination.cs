using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Destination
	{
		[Key]
		public int destinationId { get; set; }
		public string? city { get; set; }
		public string? dayNight { get; set; }
		public double price { get; set; }
		public string? image { get; set; }
		public string? description { get; set; }
		public int capacity { get; set; }
		public bool status { get; set; }
		public DateTime Date {  get; set; }
		public string? coverImage { get; set; }
		public string? details1 { get; set; }
		public string? details2 { get; set; }
		public string? image2 { get; set; }
		public List<Comment> comments {  get; set; } 
		public List<Reservation> reservations { get; set; }
		public int? GuideId { get; set; }
		public Guide Guide { get; set; }

    }
}
