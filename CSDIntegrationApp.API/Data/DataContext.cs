using CSDIntegrationApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CSDIntegrationApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<IntegrationRec> IntegrationLog { get; set; }
    }
}