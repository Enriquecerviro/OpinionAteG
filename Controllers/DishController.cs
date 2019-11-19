using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.Extensions.Logging;
using OpinionAte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpinionAte.Controllers
{
    public class DishController : JsonApiController<Dish>
    {
        public DishController(
        IJsonApiContext jsonApiContext,
        IResourceService<Dish> resourceService,
        ILoggerFactory loggerFactory)
        : base(jsonApiContext, resourceService, loggerFactory)
        { }
    }
}
