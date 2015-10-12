using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.ModelBinding;
using System.Web.OData;
using System.Web.OData.Query;
using System.Web.OData.Routing;
using Demo.Models;
using Microsoft.OData.Core;
using Demo.DataSource;


namespace Demo.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using Demo.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Trip>("Trips");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class TripsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Trips
        public IHttpActionResult GetTrips(ODataQueryOptions<Trip> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

             return Ok<IEnumerable<Trip>>(Trips);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/Trips(5)
        public IHttpActionResult GetTrip([FromODataUri] string key, ODataQueryOptions<Trip> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<Trip>(trip);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Trips(5)
        public IHttpActionResult Put([FromODataUri] string key, Delta<Trip> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(trip);

            // TODO: Save the patched entity.

            // return Updated(trip);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Trips
        public IHttpActionResult Post(Trip trip)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(trip);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Trips(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] string key, Delta<Trip> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(trip);

            // TODO: Save the patched entity.

            // return Updated(trip);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Trips(5)
        public IHttpActionResult Delete([FromODataUri] string key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
