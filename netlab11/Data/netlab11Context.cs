using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netlab11.Models;

namespace netlab11.Data
{
    public class netlab11Context : DbContext
    {
        public netlab11Context (DbContextOptions<netlab11Context> options)
            : base(options)
        {
        }

        public DbSet<netlab11.Models.Producto> Producto { get; set; } = default!;

        public DbSet<netlab11.Models.Customer> Customer { get; set; } = default!;
    }
}
