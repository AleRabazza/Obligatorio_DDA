using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Obligatorio_DDA.src.Models;


namespace Obligatorio_DDA.src.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

     
    }
}
