using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class Bangluong
    {
        [Key]
        public int bacluong { get; set; }
        public float hesoluong { get; set; }
        public float luongcoban { get; set; }
        public float hsphucap { get; set; }
    }
}
