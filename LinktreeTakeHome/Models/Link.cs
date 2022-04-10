using System;
using System.ComponentModel.DataAnnotations;

namespace LinktreeTakeHome.Models
{
	// New link types can extend on this core functionality
	public abstract class Link
	{
		// The Link Id (serverside generated)
		public int? Id { get; set; }
		[Required(ErrorMessage = "Url is required.")]
		public Uri Url { get; set; }
		[Required(ErrorMessage = "User id is required.")]
		// The Id of the User generating the link Link Id (clientside given)
		public int UserId { get; set; }
		public DateTime? DateCreated { get; set; }
		
	};

 
}

