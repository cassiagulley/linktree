using System;
namespace LinktreeTakeHome.Models
{
	public class ShowsLink : Link
	{
		// Both theese could be set to date/time format for extensibility
		// Determines if a show is sold out
		public bool SoldOut { get; set; }
		// Sets the availability/visibility of a show
		public bool Available { get; set; }
	}
}

