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
    public class ValuesController : ControllerBase
    {
        private string[] days = { "Monday", "Tueday", "Websday", "FiveDay", "Sixday", "Sunday" };
        private readonly NhanvienContext context;

        public ValuesController(NhanvienContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nhanvien>>> getListNhanvien()
        {

            return CreatedAtAction("Hello",new { status = true, message = "OK", Nhanvien =await context.Nhanvien.ToListAsync()});
        }
        [HttpGet ("{id}")]
        public async Task<ActionResult<Nhanvien>> getNhanvien(string id)
        {
            var nhanvien = await context.Nhanvien.FindAsync(id);
            if(nhanvien == null)
            {
                return NotFound();
            }
            return CreatedAtAction("NhanVien",nhanvien);
        }

        [HttpPost]
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Nhanvien>> PostNhanvien(Nhanvien nv)
        {
            if(nv.manhanvien == null || nv.manhanvien =="")
            {
                return NotFound(new Message() { status = "404", message = "khong nen de trong" });
            }
           
            var nhanvien = await context.Nhanvien.FindAsync(nv.manhanvien);
            if(nhanvien != null)
            {
                return NotFound(new Message() { status = "404", message = "da ton tai" });
            }
            if (ModelState.IsValid)
            {
                try
                {
                    context.Add(nv);
                    await context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound(new Message() { status = "404", message = "error" });
                }
            }
            return Ok(nv);
        }

        [HttpPost]
        [Route("deleteNhanvien")]
        public async Task<IActionResult> deleteNhanvien( Nhanvien nv)
        {
            if(nv.manhanvien ==null || nv.manhanvien == "")
            {
                return NotFound(new Message() { status = "404", message = "ma nhan vien khong nen bo trong" });
            }
            var nhanvien = await context.Nhanvien.FindAsync(nv.manhanvien);
            if(nhanvien == null)
            {
                return NotFound(new Message() { status = "404", message = "nhan vien nay khong ton tai" });
            }
            try
            {
                context.Nhanvien.Remove(nhanvien);
                await context.SaveChangesAsync();
                return Ok(new { status = true, message="Xoa nhan vien thanh cong"} );
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound(new Message() { status = "404", message = "nhan vien nay khong ton tai" });
            }
        }
    
        [HttpPost]
        [Route("editNhanvien")]
        public async Task<ActionResult<Nhanvien>> EditNhanvien(Nhanvien nv)
        {
            if(nv.manhanvien == null || nv.manhanvien == "")
            {
                return Ok(new { status = false, message = "Ma nhan khong ton tai" });
            }
            
            var nhanvienmoi = await context.Nhanvien.FindAsync(nv.manhanvien);
             //var entity = await context.Nhanvien.FirstOrDefaultAsync(item => item.manhanvien == nv.manhanvien);
             
            if (nhanvienmoi == null)
            {
                return Ok(new { status = false, message = "Nhan vien khong ton tai" });
            }
            //nhanvienmoi = nv;

            context.Nhanvien.Attach(nv);
           
            
            try
            {
                
                context.Entry(nv).State = EntityState.Modified;
                await context.SaveChangesAsync();
                
                return Ok( new { status = true, message = "Cap  nhat thanh cong", nhanvienmoi });
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> editEmployer(string id,Nhanvien nv)
        {
            if(id != nv.manhanvien)
            {
                return BadRequest();
            }
            context.Entry(nv).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
