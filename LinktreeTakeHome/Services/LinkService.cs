using System;
using LinktreeTakeHome.Models;

namespace LinktreeTakeHome.Services
{
    // TODO: Unit test functionality

	// Creating an in-memory link data service class with given links for ease of testing
	public static class LinkService {

        static List<Link> Links { get; }
        static DateTime day1 = new DateTime(2022, 1, 1);
        static DateTime day2 = new DateTime(2022, 1, 2);
        static DateTime day3 = new DateTime(2022, 1, 3);
        static int nextId = 9;

        static LinkService() {
            Links = new List<Link>
            {
                new ClassicLink { Id = 1, Url = null, DateCreated = day1, UserId = 1, Title = "ClassicLink1" },
                new ClassicLink { Id = 2, Url = null, DateCreated = day2, UserId = 2, Title = "ClassicLink2" },
                new ShowsLink { Id = 3, Url = null, DateCreated = day3, UserId = 1, SoldOut = false, Available = true },
                new ShowsLink { Id = 4, Url = null, DateCreated = day1, UserId = 2, SoldOut = true, Available = true },
                new ShowsLink { Id = 5, Url = null, DateCreated = day2, UserId = 1, SoldOut = false, Available = false },
                new ShowsLink { Id = 6, Url = null, DateCreated = day3, UserId = 2, SoldOut = false, Available = true },
                new MusicStyle { Id = 7, Url = null, DateCreated = day1, UserId = 1 },
                new MusicStyle { Id = 8, Url = null, DateCreated = day2, UserId = 2 }
            };
        }


        public static List<Link> GetUserLinks(int userId)
        {
            //TODO: Error checking and input validation for links - null/wrong inputs

            List<Link> userLinks = new List<Link>();

            foreach (Link link in Links) {
                if (link.UserId == userId) {
                    userLinks.Add(link);
                }
            }

            //Sort list by date created
			userLinks = userLinks.OrderBy(x => x.DateCreated).ToList();

            return userLinks;
        }

        public static List<Link> GetAll() => Links;

        // TODO: Check for edge cases and nullable values
        public static Link? Get(int id) => Links.FirstOrDefault(p => p.Id == id);

        // TODO: Absrtact out Link creation logic
        public static void AddClassicLink(ClassicLink link)
        {
            // Assign date created
            link.DateCreated = DateTime.Now;

            // The assumption is that the serverside generates new Id's 
            link.Id = nextId++;

            Links.Add(link);
        }

        public static void AddShowsLink(Link link)
        {
            // Assign date created
            link.DateCreated = DateTime.Now;

            // The assumption is that the serverside generates new Id's 
            link.Id = nextId++;

            Links.Add(link);
        }

        public static void AddMusicLink(Link link)
        {
            // Assign date created
            link.DateCreated = DateTime.Now;

            // The assumption is that the serverside generates new Id's 
            link.Id = nextId++;

            Links.Add(link);
        }

    }

}

