using System;
using System.ComponentModel.DataAnnotations;

namespace LinktreeTakeHome.Models
{
	public class ClassicLink : Link
	{
		[StringLength(144, ErrorMessage = "Name length can't be more than 144")]
		public string Title { get; set; }
		// TODO: Store optional query parameters?
	}
}

