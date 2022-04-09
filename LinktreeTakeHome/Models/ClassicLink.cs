using System;
namespace LinktreeTakeHome.Models
{
	public class ClassicLink
	{
		public int Id { get; set;}
		public Uri Url { get; set;}
		public string Title { get; set; }
		// TODO: Store optional query parameters? Could be implemented
		// in the controller class instead.
	}
}

