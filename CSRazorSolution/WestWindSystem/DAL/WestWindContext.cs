using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using WestWindSystem.Entities;
using Microsoft.EntityFrameworkCore;
#endregion

namespace WestWindSystem.DAL
{
    internal class WestWindContext : DbContext
    {
        public WestWindContext(DbContextOptions<WestWindContext> options) : base(options)
        {

        }
        public DbSet<BuildVersion> BuildVersions { get; set; }
    }
}
