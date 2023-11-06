using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlakDukkaniData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkaniDAL.Configs
{
    public class AlbumConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Album_Table");
            builder.Property(x => x.AlbumName)
                .HasColumnName("Album_Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            builder.Property(x => x.ReleaseDate)
                .HasColumnName("Release_Date")
                .HasColumnType("datetime2");
            builder.Property(x => x.Musician)
                .HasColumnName("Musician_Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
        }
    }
}
