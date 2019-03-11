using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Models
{
    public class FilmesContext : DbContext
    {
        public FilmesContext (DbContextOptions<FilmesContext> options)
            : base(options)
        {
        }

        public DbSet<Filmes.Models.Filme> Filme { get; set; }
    }
}
