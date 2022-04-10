using System;
namespace LinktreeTakeHome.Models
{
	public abstract class Link
	{
		public int Id { get; set; }
		public Uri Url { get; set; }
		public int UserId { get; set; }
	}
}

