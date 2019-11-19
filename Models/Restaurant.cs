using JsonApiDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpinionAte.Models
{
    public class Restaurant : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        [Attr("address")]
        public int Address { get; set; }

        [HasMany("dishes")]
        public virtual List<Dish> Dishes { get; set; }
    }
}
