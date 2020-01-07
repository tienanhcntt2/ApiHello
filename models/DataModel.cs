using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class DataModel
    {
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey(nameof(nhanvien))]
        public Nhanvien nhanvien { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey(nameof(Bophan))]
        public Bophan Bophan { get; set; }

    }
}
