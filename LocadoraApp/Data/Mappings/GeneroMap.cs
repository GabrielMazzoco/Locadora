

using LocadoraApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraApp.Data.Mappings
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Generos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name).HasColumnName("Name")
                .IsRequired().HasMaxLength(50).HasColumnType("Varchar(50)");
        }
    }
}
