using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    internal class S_CartConfiguration : IEntityTypeConfiguration<S_Cart>
    {

        public void Configure(EntityTypeBuilder<S_Cart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DateIn).IsRequired(false);
            builder.Property(x => x.DateOut).IsRequired();

        }
    }
}
