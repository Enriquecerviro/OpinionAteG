using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OpinionAte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpinionAte.Controllers
{
    public class RestaurantController : JsonApiController<Restaurant>
    {
        public RestaurantController(
        IJsonApiContext jsonApiContext,
        IResourceService<Restaurant> resourceService,
        ILoggerFactory loggerFactory)
        : base(jsonApiContext, resourceService, loggerFactory)
        { }
    }
}
