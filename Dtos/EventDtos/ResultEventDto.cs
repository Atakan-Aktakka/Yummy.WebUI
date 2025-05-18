using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yummy.WebUI.Dtos.EventDtos
{
    public class ResultEventDto
    {
        public int YummyEventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
    }
}