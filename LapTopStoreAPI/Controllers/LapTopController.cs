using LapTopStoreAPI.DB;
using LapTopStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LapTopStoreAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LapTopController : ControllerBase
{
    private readonly LapTopContext _context;

    public LapTopController()
    {
        _context = new LapTopContext();
    }

    [HttpGet]
    public IActionResult Read()
    {
        var lst = _context.Products.ToList();
        return Ok(lst);
    }

    [HttpPost]
    public IActionResult Create(Product p)
    {
        _context.Products.Add(p);
        var result = _context.SaveChanges();
        string message = result > 0 ? "Create Successfully" : "Create Fail";
        return Ok(message);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var item = _context.Products.FirstOrDefault(x => x.ProductId == id);
        if(item is null)
        {
            return NotFound("Product Not Found");
        }

        var result = _context.SaveChanges();
        string message = result > 0 ? "Delete Successfully" : "Delete Fail";
        return Ok(message);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product p)
    {
        var item = _context.Products.FirstOrDefault(x => x.ProductId == id);
        if(item is null) 
        {
            return NotFound("Item not found");
        }
        var result = _context.SaveChanges();
        string message = result > 0 ? "Update Successfully" : "Update Fail";
        return Ok(message);
    }

}
