using LocadoraApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraApp.Data.Mappings
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filmes");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.DiretorId)
                .HasColumnName("DiretorId");

            builder.Property(x => x.GeneroId)
                .HasColumnName("GeneroId");

            builder.Property(x => x.Sinopse)
                .HasColumnName("Sinopse")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.HasOne(x => x.Diretor)
                .WithMany(x => x.Filmes)
                .HasForeignKey(x => x.DiretorId);

            builder.HasOne(x => x.Genero)
                .WithMany(x => x.Filmes)
                .HasForeignKey(x => x.GeneroId);

        }
    }
}
