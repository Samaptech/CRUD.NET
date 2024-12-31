using CRUD.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.NET.SqlDb
{
    public class SqlDbContext :DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) 
        { 
            
            

        }
        public DbSet<Products> tbl_Products { get; set; }

        public DbSet<Customer>tbl_Customers { get; set; }

        public DbSet<Users>tbl_Users { get; set; }
    }
}
