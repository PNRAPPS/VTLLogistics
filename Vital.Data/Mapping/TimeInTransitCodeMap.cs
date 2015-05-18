using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vital.Data.Models.Mapping
{
    public class TimeInTransitCodeMap : EntityTypeConfiguration<TimeInTransitCode>
    {
        public TimeInTransitCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("TimeInTransitCode");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.From).HasColumnName("From");
            this.Property(t => t.To).HasColumnName("To");
            this.Property(t => t.Code).HasColumnName("Code");

        }
    }
}
