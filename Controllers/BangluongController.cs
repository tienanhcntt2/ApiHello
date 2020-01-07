using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloApi.models;
using HelloApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelloApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BangluongController : ControllerBase
    {
        private readonly NhanvienContext context;
        public BangluongController(NhanvienContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bangluong>>> getListBangluong()
        {
            return CreatedAtAction("", new { Status = true, Message = "List bang luong", Bangluong = await context.Bangluong.ToListAsync()});
        }

        [HttpPost]
        [Route("addBangluong")]
        public async Task<ActionResult<Bangluong>> addBangluong(Bangluong bl)
        {

            var bangluong = await context.Bangluong.FindAsync(bl.bacluong);
            if(bangluong != null)
            {
                return Ok(new { Status = false, Message = "Ma bac luong da ton tai" });
            }
            if (ModelState.IsValid)
            {
                try
                {
                    context.Add(bl);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Ok(new { Status = false, Message = "Erro" });
                }
            }
            return CreatedAtAction("", new { Status = true, Message = "Success", Bangluong = bl });

        }

    }
}