
namespace Services.Backend.Models
{
    using Domain.Models;


    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Services.Common.Models.Product> Products { get; set; }
    }
}