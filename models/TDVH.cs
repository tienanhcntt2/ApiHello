using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class TDVH
    {
        [Key]
        public string matdvh { get; set; }
        public string tentdvh { get; set; }
        public string chuyennganh { get; set; }
    }
}
