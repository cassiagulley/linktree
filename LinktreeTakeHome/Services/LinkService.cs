using System;
using LinktreeTakeHome.Models;

namespace LinktreeTakeHome.Services
{
	// An in-memory link data service class
	public static class LinkService
	{

        static LinkService() {
            Links = new List<Link>
        {
            new ClassicLink { Id = 1, Url = null, UserId = 1, Title = "ClassicLink1" },
            new ClassicLink { Id = 2, Url = null, UserId = 2, Title = "ClassicLink2" },
            new ShowsLink { Id = 3, Url = null, UserId = 1, SoldOut = false, Available = true },
            new ShowsLink { Id = 4, Url = null, UserId = 2, SoldOut = true, Available = true },
            new ShowsLink { Id = 5, Url = null, UserId = 1, SoldOut = false, Available = false },
            new ShowsLink { Id = 6, Url = null, UserId = 2, SoldOut = false, Available = true },
            new MusicStyle { Id = 7, Url = null, UserId = 1 },
            new MusicStyle { Id = 8, Url = null, UserId = 2 },
        };
        }




        static List<Link> Links { get; }

        // TODO: Create/add new links here for preliminary testing

        // TODO: Add helper functions to match poject specifications

        public static List<Link> GetAll() => Links;


        // TODO: Check for edge cases and nullable values
        public static Link? Get(int id) => Links.FirstOrDefault(p => p.Id == id);

        public static void Add(Link link)
        {
            // Do links need to generate new Ids or are they given?
            Links.Add(link);
        }

        public static void Delete(int id)
        {
            var link = Get(id);
            if (link is null)
                return;

            Links.Remove(link);
        }

        public static void Update(Link link)
        {
            var index = Links.FindIndex(p => p.Id == link.Id);
            if (index == -1)
                return;

            Links[index] = link;
        }

    }


}

