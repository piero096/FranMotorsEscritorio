using Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection.Mapping
{
    internal class MotoMap: IEntityTypeConfiguration<Moto>
    {
        public void Configure(EntityTypeBuilder<Moto> builder)
        {
            builder.ToTable("Moto");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Cliente)
                .WithMany()
                .HasForeignKey(o => o.Id_Cliente);
        }
    }
}
