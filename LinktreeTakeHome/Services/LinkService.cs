using System;
using LinktreeTakeHome.Models;

namespace LinktreeTakeHome.Services
{
	// An in-memory link data service class
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


        public static void Add(Link link)
        {
            // TODO: common link error and imput checking

            // The assumption is that the serverside generates new Id's 
            link.Id = nextId++;

            if (link.LinkType.Equals(1)) { // Classic Link

                AddClassicLink(Link link);

            } else if (link.LinkType.Equals(2)) { // Shows Link

                AddShowsLink(Link link);

            } else if (link.LinkType.Equals(3)) { // Music Link

                AddMusicLink(Link link);

            } else {

                // Throw incorrect link type error

            }


            Links.Add(link);

        }

        public static void AddClassicLink(Link link) {
            // TODO: link type specific checking

        }

        public static void AddShowsLink(Link link){
            // TODO: link type specific checking


        }

        public static void AddMusicLink(Link link)
        {
            // TODO: link type specific checking

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

