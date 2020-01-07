using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApi.models
{
    public class Nhanvien
    {
        [Key]
        public string manhanvien { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public string dienthoai { get; set; }
        public string mabophan { get; set; }
        [DataType(DataType.Date)]
        public DateTime ngaysinh { get; set; }
        public int gioitinh { get; set; }
        public string macv { get; set; }
        public string TDVH { get; set; }
        public int bacluong { get; set; }

    }
}
