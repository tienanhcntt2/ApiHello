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
    public class BophanController : ControllerBase
    {

        private readonly NhanvienContext context;
        
        public BophanController(NhanvienContext _context)
        {
            context = _context;
        }
       
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bophan>>> getListBophan()
        {

            return CreatedAtAction("", new { status = true, message = "List bo phan", Bophan= await context.Bophan.ToListAsync()});
        }
        [HttpPost]
        [Route("addBophan")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Bophan>> addBoPhan(Bophan bophan)
        {
            if (bophan.mabophan == null || bophan.mabophan == "")
            {
                return BadRequest();
            }
            var newBophan = await context.Bophan.FindAsync(bophan.mabophan);
            if (newBophan != null)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    context.Add(bophan);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound(new { status = "404", message = "error" });
                }
            }
            return CreatedAtAction("", new { status = true, Bophan = bophan });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> editBophan(string id,Bophan bophan)
        {
            if(id != bophan.mabophan)
            {
                return Ok(new { Status = false, Message = "Ma bo phan khong ton tai" });
            }
            context.Entry(bophan).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }
            return CreatedAtAction("", new { status = true, Bophan = bophan });
        }

        [HttpGet("{id}")]
       
        public async Task<ActionResult<Bophan>> getItemBophan(string id)
        {
            var bophan = await context.Bophan.FindAsync(id);
            if(bophan == null)
            {
                return Ok(new { Status = false, Message = "Bo phan khong ton tai" });
            }
            return CreatedAtAction("", new { Status = true, Bophan = bophan });
        }
        //[HttpDelete("{id}")]

        
        [HttpPost]
        [Route("deleteBophan")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> deleteBophan(Bophan bp)
        {
            var _bophan = await context.Bophan.FindAsync(bp.mabophan);
            
            if (_bophan == null)
            {
                return Ok(new { Status = false, Message = "Bo phan khong ton tai" });
            }
          
            try
            {
                  context.Bophan.Remove(_bophan);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Ok(new { Status = false, Message = "Bo phan khong ton tai" });
            }
            return CreatedAtAction("", new { Status = true, Message = "Xoa thanh cong" });
        }
    }
}