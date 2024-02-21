using System.Data.Entity;
using InterviuPam.Web.Models;

namespace InterviuPam.Web;

public class AdventureWorksContext : DbContext {
    public AdventureWorksContext(string connectionString) : base(connectionString) {

    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<CustomerAddress> CustomerAddresses { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        modelBuilder.Entity<CustomerAddress>()
            .HasRequired(e => e.Address)
            .WithMany(e=>e.CustomerAddresses)
            .HasForeignKey(e=>e.AddressID)
            ;

        modelBuilder.Entity<CustomerAddress>()
            .HasRequired(e => e.Customer)
            .WithMany(e => e.CustomerAddresses)
            .HasForeignKey(e => e.CustomerID);
    }
}
