using Microsoft.EntityFrameworkCore;

namespace EFCore_DBLibrary
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
                
        }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}