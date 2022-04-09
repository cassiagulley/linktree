using System;
using LinktreeTakeHome.Models;

namespace LinktreeTakeHome.Services
{
	// An in-memory link data service class
	public static class LinkService
	{
		static List<Link> Links { get; }


		public static  LinkService()
		{
			// TODO: Create/add new links here for preliminary testing
		}

        // TODO: Add helper functions to match poject specifications

        public static List<Link> GetAll() => Links;

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

