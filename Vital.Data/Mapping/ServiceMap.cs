using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vital.Data.Models.Mapping
{
    public class ServiceMap : EntityTypeConfiguration<Service>
    {
        public ServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Service");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ServiceName).HasColumnName("ServiceName");
            this.Property(t => t.RateCode).HasColumnName("RateCode");
            this.Property(t => t.ShipmentCode).HasColumnName("ShipmentCode");

        }
    }
}
