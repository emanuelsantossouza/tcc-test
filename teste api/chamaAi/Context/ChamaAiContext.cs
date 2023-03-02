using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using chamaAi.Entities;

namespace chamaAi.Context
{
    public class ChamaAiContext : DbContext
    {
        public ChamaAiContext(DbContextOptions<ChamaAiContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get ; set ; }        
    }
}