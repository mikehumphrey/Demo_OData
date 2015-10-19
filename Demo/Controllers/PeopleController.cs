using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Query;
using Demo.Models;
using Microsoft.OData.Core;
using Demo.DataSource;
using System.Linq;

namespace Demo.Controllers
{
    [EnableQuery]
    public class peopleController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(DemoDataSources.Instance.People.AsQueryable());
        }
    }
}
