using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDotNetOfficial.Models.Data;


public class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null;
    public DbSet<Order> Orders { get; set; } = null;
    public DbSet<Product> Products { get; set; } = null;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null;

    //Access Modifier return type
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Verbatim String
        optionsBuilder.UseSqlServer(@"Server=nexuslite-pc\sqlexpress;Database=Bulky;User Id=sa;Password=Predeator;Trusted_Connection=False;TrustServerCertificate=True;MultipleActiveResultSets=true");
    }

}
