using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DomenicaEscobar_ExamenP1.Models;

namespace DomenicaEscobar_ExamenP1.Data
{
    public class DomenicaEscobar_ExamenP1Context : DbContext
    {
        public DomenicaEscobar_ExamenP1Context (DbContextOptions<DomenicaEscobar_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<DomenicaEscobar_ExamenP1.Models.DomenicaEscobar_Tabla> DomenicaEscobar_Tabla { get; set; } = default!;
    }
}
