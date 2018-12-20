using LocadoraApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraApp.Data.Mappings
{
    public class DiretorMap : IEntityTypeConfiguration<Diretor>
    {
        public void Configure(EntityTypeBuilder<Diretor> builder)
        {
            builder.ToTable("Diretores");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name).HasColumnName("Name")
                .IsRequired().HasMaxLength(50).HasColumnType("Varchar(50)");

            builder.Property(x => x.Idade).HasColumnName("Idade");
        }
    }
}
