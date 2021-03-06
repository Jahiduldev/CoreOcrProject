using Microsoft.EntityFrameworkCore;
using OcrRndProject.DAL.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrRndProject.DAL
{
    public class OCrRndProjectDbContext : DbContext
    {



        public OCrRndProjectDbContext(DbContextOptions<OCrRndProjectDbContext> options) : base(options)
        {

        }
        public DbSet<NidInformations> NidInformations { get; set; }
        public DbSet<NidAddressInfo> NidAddressInfo { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }


         
    }
}
