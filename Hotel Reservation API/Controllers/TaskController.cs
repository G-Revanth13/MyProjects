using revanth.Models;
using revanth.rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace revanth.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class TaskController : ApiController
    {
        public readonly IReservation res;
        public TaskController(IReservation an)
        {
             this.res=an;
        }
        [Route("api/Task/GetAllPassengers")]
        [HttpGet]
        public IHttpActionResult ses()
        {
            var b = res.GetAllPassengers();
            if (b.Count == 0)
            {
                 NotFound();
            }
            return Ok(b);
        }
        [Route("api/Task/insertpassengers")]
        [HttpPost]
        public IHttpActionResult ses(ReservationModel rm)
        {
            var c = res.insertpassengers(rm);
            if(c==null)
            {
                return NotFound();
            }
            return Ok();
        }
        [Route("api/Task/updatepassengers")]
        [HttpPost]
        public IHttpActionResult sen(ReservationModel rs)
        {
            var d = res.updatepassengers(rs);
            if(d== null)
            {
                return NotFound();
            }
            return Ok();
        }
        [Route("api/Task/deletepassengers/{Id}")]
        [HttpDelete]
        public IHttpActionResult sun(int Id)
        {
            var e = res.deletepassengers(Id);
            if(e==null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
