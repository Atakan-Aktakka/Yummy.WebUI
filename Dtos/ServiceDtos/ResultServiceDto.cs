using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yummy.WebUI.Dtos.ServiceDtos
{
    public class ResultServiceDto
    {
        public int ServiceId { get; set; }
        public string? Title { get; set; }
        public string? IconUrl { get; set; }
        public string? Description { get; set; }
    }
}