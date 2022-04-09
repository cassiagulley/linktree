using System;
namespace LinktreeTakeHome.Models
{
	public class ClassicLink : Link
	{
		// Both theese could be set to date/time format for extensibility
		public bool SoldOut { get; set; }
		public bool Available { get; set; }
	}
}

