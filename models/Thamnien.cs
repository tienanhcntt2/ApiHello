using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class Thamnien
    {
        public string manhanvien { get; set; }
        public string macv { get; set; }
        [DataType(DataType.Date)]
        public DateTime ngaynhamchuc { get; set; }
    }
}
