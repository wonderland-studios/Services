
namespace Services.Backend.Models
{
    using Domain.Models;


    public class LocalDataContext : DataContext
    {
        private System.Data.Entity.DbSet<Common.Models.Product> Products { get; set; }

    }
}