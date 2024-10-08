using EhandelsplatformforKunstnere.Models;
using Microsoft.EntityFrameworkCore;

namespace EhandelsplatformforKunstnere.Context;


public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<User> Posts { get; set; }
}
