using Microsoft.EntityFrameworkCore;
using DorsetBookApi.Models;

namespace DorsetBookApi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Book> Book { get; set; }
    }
}