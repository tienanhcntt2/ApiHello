using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloApi.models;

namespace HelloApi.Models
{
    public class NhanvienContext : DbContext
    {
        public NhanvienContext (DbContextOptions<NhanvienContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<HelloApi.models.Nhanvien> Nhanvien { get; set; }
        public DbSet<HelloApi.models.Bophan> Bophan { get; set; }
        public DbSet<chucvu> Chucvu { get; set; }


    }
}
