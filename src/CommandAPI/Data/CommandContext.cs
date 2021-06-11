using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Data
{
    public class cd : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) :
            base(options)
        {
        }

        public DbSet<Command> CommandItems { get; set; }
    }
}
