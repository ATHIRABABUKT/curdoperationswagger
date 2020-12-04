using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curdoperationswagger.models;
using Microsoft.EntityFrameworkCore;

namespace curdoperationswagger.context
{
    public class CURDContext  : DbContext
    {
        public CURDContext(DbContextOptions<CURDContext> options) : base(options)
        {

        }
        public DbSet<student> Students { get; set; }
       
    }
}
