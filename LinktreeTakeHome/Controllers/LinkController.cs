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
        [HttpGet("userLinks/{userId}")]
        public ActionResult<List<Link>> GetUserLinks(int userId)
        {
            // Automatically sorted by date created
            List<Link> userLinks = LinkService.GetUserLinks(userId);

            if (userLinks.Count == 0 || userLinks == null)
            {
                return NotFound();
            }

            return userLinks;
        }


        // POST link/classicLink
        [HttpPost("/classicLink")]
        public IActionResult Create(ClassicLink link)
        {
            // Automatically does model checking errors
            if (ModelState.IsValid)
            {
                LinkService.AddClassicLink(link);
                return CreatedAtAction(nameof(Create), new { id = link.Id }, link);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST link/showsLink
        [HttpPost("/showsLink")]
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
                return BadRequest();
            }
        }

        // POST link/musicStyle
        [HttpPost("/musicStyle")]
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
                return BadRequest();
            }
        }
    }
}

