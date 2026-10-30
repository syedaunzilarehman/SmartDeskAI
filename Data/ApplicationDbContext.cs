using Microsoft.EntityFrameworkCore;

namespace SmartDeskAI.Data
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { 
        
        }
        public DbSet<SmartDeskAI.Models.SupportTicket> SupportTickets { get; set; }
    }
}
