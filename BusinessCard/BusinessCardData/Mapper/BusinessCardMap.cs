using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BusinessCardCore.Models;

namespace BusinessCardData.Mapper
{
    public class BusinessCardMap : EntityTypeConfiguration<BusinessCard>
    {
        public BusinessCardMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired();
            Property(t => t.Email);
            Property(t => t.MobilePhone);
            Property(t => t.CompanyName);
            Property(t => t.TitlePosition);
            ToTable("Card");
        }
    }
}
