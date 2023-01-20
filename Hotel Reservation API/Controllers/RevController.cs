using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using revanth.Models;
using revanth.rep;

namespace revanth.Controllers
{
    public class RevController : ApiController
    {
        public readonly Ant an;
        public RevController() { }
        public RevController(Ant ant)
        {
            an = ant;
        }

        [Route("api/Rev/GetAllEmployees")]
        [HttpGet]
        public IHttpActionResult sashi()
        {
            var b = an.GetAllEmployees();
            if(b.Count == 0)
            {
                NotFound();
            }
            return Ok(b);
        }

        [Route("api/Rev/GetUpdatedData")]
        [HttpPost]
        public IHttpActionResult sunil(sam r)
        {
            var d = an.updatemployee(r);
            if(d==null)
            {
                return NotFound();
            }
            return Ok(d);
        }

        [Route("api/Rev/GetInserted")]
        [HttpPost]
        public IHttpActionResult sai(sam g)
        {
            var h = an.insertemployee(g);
            if (h==null)
            {
                return NotFound();
            }
            return Ok();
        }
        
        [Route("api/Rev/deletedata/{d}")]
        [HttpDelete]
        public IHttpActionResult rev(int d)
        {
            var i = an.deleteemploye(d);
            if(i==null)     
            {
                return NotFound();
            }
            return Ok();

        }

        [Route("api/Rev/insertbulkdata")]
        [HttpPost]
        public IHttpActionResult shiv(List<sam> l)
        {
            var re = an.bulkdata( l);
             if (re ==null)
             {
                return NotFound();
             }
            return Ok();

        }

        [Route("api/Rev/getbyID/{ID}")]
        [HttpGet]
        public IHttpActionResult getbyid(int ID)
        {
            var i = an.getbyid(ID);
            if (i == null)
            {
                return NotFound();
            }
            return Ok(i);
        }
    
        
    }
}
