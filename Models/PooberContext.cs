using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Poober.Models
{
    public class PooberContext : DbContext
    {
        public PooberContext(DbContextOptions<PooberContext> options)
            : base(options)
        { }

        //MODELS
        public DbSet<Pooper> poopers { get; set; }
        public DbSet<Scooper> scoopers { get; set; }
        public DbSet<Job> jobs { get; set; }
        public DbSet<FinishedJob> finishedJobs { get; set; }
    }
}
