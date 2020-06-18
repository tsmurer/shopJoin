using Microsoft.EntityFrameworkCore;

namespace ShopJoin.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
    }
}