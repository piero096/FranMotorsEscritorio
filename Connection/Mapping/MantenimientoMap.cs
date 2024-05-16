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
    internal class MantenimientoMap: IEntityTypeConfiguration<Mantenimiento>
    {
        public void Configure(EntityTypeBuilder<Mantenimiento> builder)
        {
            builder.ToTable("Mantenimiento");
            builder.HasKey(o => o.id);

            builder.HasOne(o => o.moto)
                .WithMany()
                .HasForeignKey(o => o.Id_Moto);

            builder.HasOne(o => o.producto)
                .WithMany()
                .HasForeignKey(o => o.Id_Producto);
        }
    }
}
