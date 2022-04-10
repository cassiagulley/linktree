using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LinktreeTakeHome.Models;
using LinktreeTakeHome.Services;

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

        // GET link/links/userId
        [HttpGet("userlinks/{UserId}")]
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



        // POST link/links
        [HttpPost]
        public IActionResult Create(Link link)
        {

            //Do error checking later


            LinkService.Add(link);
            return CreatedAtAction(nameof(Create), new { id = link.Id }, link);
        }
        

        // PUT link/links/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {



            // error checking 



        }

        // DELETE link/links/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

