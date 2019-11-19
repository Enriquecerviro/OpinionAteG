using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpinionAte.Models
{
    public class Dish : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        [Attr("rating")]
        public int rating { get; set; }

        [HasOne("restaurant")]
        public virtual Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}
