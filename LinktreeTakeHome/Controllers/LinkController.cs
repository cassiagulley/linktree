using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LinktreeTakeHome.Models;
using LinktreeTakeHome.Services;
using System.Net;


namespace LinktreeTakeHome.Controllers
{
    [Route("[controller]")]
    public class LinkController : ControllerBase
    {
        // GET: link/links
        [HttpGet]
        public ActionResult<List<Link>> Get()
        {
            return LinkService.GetAll();
        }

        // GET link/links/linkId
        [HttpGet("{id}")]
        public ActionResult<Link> Get(int id)
        {
            var link = LinkService.Get(id);

            if (link == null) {
                return NotFound();
            }

            return link;
        }

        // GET link/user/userId
        [HttpGet("userLinks/{UserId}")]
        public ActionResult<List<Link>> GetUserLinks(int UserId)
        {
            // Automatically sorted by date created
            List<Link> userLinks = LinkService.GetUserLinks(UserId);

            if (userLinks.Count == 0 || userLinks == null)
            {
                return NotFound();
            }

            return userLinks;
        }


        // POST link/classiclinks
        [HttpPost("/classiclink")]
        public IActionResult Create([FromBody]ClassicLink link)
        {
            // Automatically does model checking errors
            if (ModelState.IsValid)
            {
                LinkService.AddClassicLink(link);
                return CreatedAtAction(nameof(Create), new { id = link.Id }, link);
            }
            else
            {
                //TODO: error handling
            }
        }

        // POST link/classiclinks
        [HttpPost("/showslink")]
        public IActionResult Create(ShowsLink link)
        {
            // Automatically does model checking errors
            if (ModelState.IsValid)
            {
                LinkService.AddShowsLink(link);
                return CreatedAtAction(nameof(Create), new { id = link.Id }, link);
            }
            else
            {
                //TODO: error handling
            }
        }

        // POST link/classiclinks
        [HttpPost("/musicstyle")]
        public IActionResult Create(MusicStyle link)
        {
            // Automatically does model checking errors
            if (ModelState.IsValid)
            {
                LinkService.AddMusicStyle(link);
                return CreatedAtAction(nameof(Create), new { id = link.Id }, link);
            }
            else
            {
                //TODO: error handling
            }
        }
    }
}

