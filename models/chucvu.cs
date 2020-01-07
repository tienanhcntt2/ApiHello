using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class chucvu
    {
        [Key]
        public string macv { get; set; }
        public string tenchucvu { get; set; }
    }
}
