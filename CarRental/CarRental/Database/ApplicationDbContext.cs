using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Database.Tables;
using Microsoft.EntityFrameworkCore;


namespace CarRental.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }
        public DbSet<ListaSamochodw> ListaSamochodow { get; set; }
        public DbSet<Pracownicy> Pracownicy { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<ZamowieniaSamochodw> ZamowieniaSamochodow { get; set; }
    }
}
