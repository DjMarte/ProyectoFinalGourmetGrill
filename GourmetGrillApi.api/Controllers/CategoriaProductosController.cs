﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GourmetGrillApi.api.DAL;
using Shared.Models;
using Shared.Interfaces;

namespace GourmetGrillApi.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriaProductosController(IServer<CategoriaProductos> service) : ControllerBase
{
    // GET: api/CategoriaProductos
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoriaProductos>>> GetCategoriaProductos()
    {
        return await service.GetAllObject();
    }

    // GET: api/CategoriaProductos/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CategoriaProductos>> GetCategoriaProductos(int id)
    {
        var categoriaProductos = await service.GetObject(id);

        if (categoriaProductos == null)
        {
            return NotFound();
        }

        return categoriaProductos;
    }

    // POST: api/CategoriaProductos
    [HttpPost]
    public async Task<ActionResult<CategoriaProductos>> PostCategoriaProductos(CategoriaProductos categoriaProducto)
    {
        var categoriaProductos = await service.AddObject(categoriaProducto);
        return CreatedAtAction(nameof(GetCategoriaProductos), new { id = categoriaProductos.CategoriaId }, categoriaProductos);
    }

    // PUT: api/CategoriaProductos/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCategoriaProductos(int id, CategoriaProductos categoriaProductos)
    {
        if (id != categoriaProductos.CategoriaId)
        {
            return BadRequest();
        }
        await service.UpdateObject(categoriaProductos);
        return NoContent();
    }

    // DELETE: api/CategoriaProductos/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategoriaProductos(int id)
    {
        var categoriaProductos = await service.DeleteObject(id);
        if (!categoriaProductos)
        {
            return NotFound();
        }

        return NoContent();
    }
}
