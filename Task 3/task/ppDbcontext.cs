using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task.ppDbcontext;

namespace task
{
    public class ppDbcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)

            {
                options.UseSqlServer(Connections.sqlconstr);
            }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
    }
}
