using System;
using System.ComponentModel.DataAnnotations;

namespace LinktreeTakeHome.Models
{
	public class ShowsLink : Link
	{
		// TODO: Both theese could be set to date/time format for automation
		// Determines if a show is sold out
		[Required(ErrorMessage = "Sold Out is required")]
		public bool SoldOut { get; set; }
		// Sets the availability/visibility of a show
		[Required(ErrorMessage = "Availability is required")]
		public bool Available { get; set; }
	}
}

