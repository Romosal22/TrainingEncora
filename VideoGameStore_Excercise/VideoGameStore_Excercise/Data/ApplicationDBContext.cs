using Microsoft.EntityFrameworkCore;
using VideoGameStore_Excercise.Models.Entities;

namespace VideoGameStore_Excercise.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
            
        }


        public DbSet<GameTitle> GameTitles { get; set; }

    }
}
