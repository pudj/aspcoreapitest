using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Show.Models
{
    public class ShowContext : DbContext{
        public ShowContext(DbContextOptions<ShowContext> options) : base(options){}
       
       public DbSet<Shows> Shows { get; set; }
    }
    public class Shows
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [System.ComponentModel.DataAnnotations.Key]
        public int ShowId { get; set; }

        public string Band { get; set; }

        public int Visitors { get; set; }

     

    }
    
}