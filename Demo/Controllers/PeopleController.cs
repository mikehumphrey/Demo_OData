using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Query;
using Demo.Models;
using Microsoft.OData.Core;
using Demo.DataSource;
using System.Linq;

namespace Demo.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using Demo.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Person>("People");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PeopleController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/People
        public IHttpActionResult GetPeople(ODataQueryOptions<Person> queryOptions)
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

            return Ok(DemoDataSources.Instance.People.AsQueryable());
            //return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/People(5)
        public IHttpActionResult GetPerson([FromODataUri] string key, ODataQueryOptions<Person> queryOptions)
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

            // return Ok<Person>(person);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/People(5)
        public IHttpActionResult Put([FromODataUri] string key, Delta<Person> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(person);

            // TODO: Save the patched entity.

            // return Updated(person);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/People
        public IHttpActionResult Post(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(person);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/People(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] string key, Delta<Person> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(person);

            // TODO: Save the patched entity.

            // return Updated(person);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/People(5)
        public IHttpActionResult Delete([FromODataUri] string key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
