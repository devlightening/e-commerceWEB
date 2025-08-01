using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class CommerceContext(DbContextOptions options) : DbContext(options)
{
  public DbSet<Product> Products => Set<Product>();

  
}