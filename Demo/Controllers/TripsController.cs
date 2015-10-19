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
    [EnableQuery]
    public class TripsController : ODataController
    {
        // GET: odata/Trips
        public IHttpActionResult Get()
        {
             return Ok(DemoDataSources.Instance.Trips.AsQueryable());
        }
    }
}
