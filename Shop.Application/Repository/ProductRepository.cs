using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Repository
{
  public class ProductRepository
  {
    private ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
      _context = context;
    }

    public void CreateProduct(int id, string name, string description)
    {
      _context.Products.Add(new Product()
      {
        Id = id,
        Name = name,
        Description = description
      });
    }
  }
}
