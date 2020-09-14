using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerApi.DataLayer.Models.Entities.Configurations
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(AR => AR.ID);
            builder.Property(AR => AR.ID).UseSqlServerIdentityColumn();

            builder.Property(SM => SM.Name)
                    .IsRequired()
                    .HasColumnType("Nvarchar(50)");

            builder.Property(SM => SM.LastName)
                    .IsRequired()
                    .HasColumnType("Nvarchar(70)");

            builder.Property(SM => SM.TelephoneNumber)
                    .IsRequired()
                    .HasColumnType("Nvarchar(20)");

            builder.Property(SM => SM.InternationalCode)
                    .IsRequired()
                    .HasColumnType("Nvarchar(10)");

            builder.Property(SM => SM.Address)
                      .IsRequired()
                      .HasColumnType("Nvarchar(1000)");

            builder.Property(SM => SM.RowVersion).IsRowVersion();
        }
    }

}
