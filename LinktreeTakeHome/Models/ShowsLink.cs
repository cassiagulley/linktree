using System;
namespace LinktreeTakeHome.Models
{
	public class ClassicLink
	{
		public int Id { get; set;}
		public Uri Url { get; set;}
		// Both theese could be set to date/time format for extensibility
		public bool SoldOut { get; set; }
		public bool Available { get; set; }
	}
}

