using System;
namespace LinktreeTakeHome.Models
{
	public abstract class Link
	{
		public abstract int Id { get; set; }
		public abstract Uri Url { get; set; }
	}
}

