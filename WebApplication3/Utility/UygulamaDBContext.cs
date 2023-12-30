using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Utility
{
    public class UygulamaDBContext : DbContext
    {
        public UygulamaDBContext(DbContextOptions<UygulamaDBContext>options) : base(options)
        {

        }
    }
}

