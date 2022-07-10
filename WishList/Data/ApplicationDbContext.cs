using Microsoft.EntityFrameworkCore;
using WishList.Model;

namespace WishList.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Model.Item > Items { get; set; }
    }
}
