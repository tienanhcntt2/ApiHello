using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class Bophan
    {
        [Key]
        public string mabophan { get; set; }
        public string tenbophan { get; set; }
        public string sdtbophan { get; set; }
        public string diachi { get; set; }

    }
}
