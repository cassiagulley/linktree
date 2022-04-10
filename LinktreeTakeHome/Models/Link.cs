using System;
namespace LinktreeTakeHome.Models
{
	public abstract class Link
	{
		public int Id { get; set; }
		public Uri Url { get; set; }
		public int UserId { get; set; }
		public DateTime DateCreated { get; set; }
		public LinkType LinkType { get; set; }
	};

    // Not sure if these are really nessesary??
    public enum LinkType
    {
		classicLink,
		showsLink,
        musicStyle,
    };
}

