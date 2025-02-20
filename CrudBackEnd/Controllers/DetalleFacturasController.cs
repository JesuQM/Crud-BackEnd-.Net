﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudBackEnd.Context;
using CrudBackEnd.Models;

namespace CrudBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleFacturasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DetalleFacturasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DetalleFacturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleFactura>>> GetDetalleFacturas()
        {
            return await _context.DetalleFacturas.ToListAsync();
        }

        // GET: api/DetalleFacturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleFactura>> GetDetalleFactura(int id)
        {
            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);

            if (detalleFactura == null)
            {
                return NotFound();
            }

            return detalleFactura;
        }

        // PUT: api/DetalleFacturas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleFactura(int id, DetalleFactura detalleFactura)
        {
            if (id != detalleFactura.Id)
            {
                return BadRequest();
            }

            _context.Entry(detalleFactura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleFacturaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DetalleFacturas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<int>> PostDetalleFactura(DetalleFactura detalleFactura)
        {
            _context.DetalleFacturas.Add(detalleFactura);
            await _context.SaveChangesAsync();

            return detalleFactura.Id;
        }

        // DELETE: api/DetalleFacturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleFactura(int id)
        {
            var detalleFactura = await _context.DetalleFacturas.FindAsync(id);
            if (detalleFactura == null)
            {
                return NotFound();
            }

            _context.DetalleFacturas.Remove(detalleFactura);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleFacturaExists(int id)
        {
            return _context.DetalleFacturas.Any(e => e.Id == id);
        }
        // GET: api/DetalleFacturas/ByFacturaId/5
        [HttpGet("ByFacturaId/{facturaId}")]
        public async Task<ActionResult<DetalleFactura>> GetDetalleFacturaByFacturaId(int facturaId)
        {
            var detalleFactura = await _context.DetalleFacturas
                                                .FirstOrDefaultAsync(df => df.FacturaId == facturaId);

            if (detalleFactura == null)
            {
                return NotFound();
            }

            return detalleFactura;
        }
        // DELETE: api/DetalleFacturas/ByFacturaId/5
        [HttpDelete("ByFacturaId/{facturaId}")]
        public async Task<IActionResult> DeleteDetalleFacturasByFacturaId(int facturaId)
        {
            var detalleFacturas = await _context.DetalleFacturas
                                                .Where(df => df.FacturaId == facturaId)
                                                .ToListAsync();

            if (detalleFacturas == null || detalleFacturas.Count == 0)
            {
                return NotFound();
            }

            _context.DetalleFacturas.RemoveRange(detalleFacturas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }


}
