using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PryUserSossaES.Models;

namespace PryUserSossaES.Controllers
{
    public class GeosController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Geos
        public IQueryable<Geo> GetGeos()
        {
            return db.Geos;
        }

        // GET: api/Geos/5
        [ResponseType(typeof(Geo))]
        public IHttpActionResult GetGeo(string id)
        {
            Geo geo = db.Geos.Find(id);
            if (geo == null)
            {
                return NotFound();
            }

            return Ok(geo);
        }

        // PUT: api/Geos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGeo(string id, Geo geo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != geo.lat)
            {
                return BadRequest();
            }

            db.Entry(geo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Geos
        [ResponseType(typeof(Geo))]
        public IHttpActionResult PostGeo(Geo geo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Geos.Add(geo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GeoExists(geo.lat))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = geo.lat }, geo);
        }

        // DELETE: api/Geos/5
        [ResponseType(typeof(Geo))]
        public IHttpActionResult DeleteGeo(string id)
        {
            Geo geo = db.Geos.Find(id);
            if (geo == null)
            {
                return NotFound();
            }

            db.Geos.Remove(geo);
            db.SaveChanges();

            return Ok(geo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GeoExists(string id)
        {
            return db.Geos.Count(e => e.lat == id) > 0;
        }
    }
}