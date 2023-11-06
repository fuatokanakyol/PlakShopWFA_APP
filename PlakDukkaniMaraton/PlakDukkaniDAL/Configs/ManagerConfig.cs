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
    public class ManagerConfig : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Manager_Table");
            builder.HasIndex(x => x.UserName).IsUnique();

            builder.Property(x => x.UserName)
                .HasColumnName("Manager_Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            builder.Property(x => x.Password)
                .HasColumnName("Password");
            builder.Property(x => x.RegisterDate)
                .HasColumnName("Register_Date")
                .HasColumnType("datetime2");
            builder.Property(x => x.UpdateDate)
                .HasColumnName("Update_Date")
                .HasColumnType("datetime2");

        }
    }
}
