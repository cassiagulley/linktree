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

        // GET link/links/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Link> Get(int id)
        {
            var link = LinkService.Get(id);

            if (link == null) {
                return NotFound();
            }

            return link;
        }

        // POST link/links
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT link/links/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE link/links/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

