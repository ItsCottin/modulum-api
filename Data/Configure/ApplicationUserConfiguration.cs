using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulum.Data;

namespace Modulum.Data.Configure
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("TBL_USUARIO");
            builder.Property(u => u.Id).HasColumnName("ID_USU");
            builder.Property(u => u.UserName).HasColumnName("LOGIN_USU");
            builder.Property(u => u.Email).HasColumnName("EMAIL_USU");
            builder.Property(u => u.EmailConfirmed).HasColumnName("EMAIL_CONFIRM_USU");
            builder.Property(u => u.PhoneNumber).HasColumnName("TELEFONE_USU");
            builder.Property(u => u.PhoneNumberConfirmed).HasColumnName("TELEFONE_CONFIRM_USU");
            builder.Property(u => u.AccessFailedCount).HasColumnName("CONT_FAIL_ACESS_USU");
            builder.Property(u => u.ConcurrencyStamp).HasColumnName("SIMULTANEIDADE_USU");
            builder.Property(u => u.LockoutEnabled).HasColumnName("INICIO_BLOQUEIO_USU");
            builder.Property(u => u.LockoutEnd).HasColumnName("FIM_BLOQUEIO_USU");
            //builder.Property(u => u.Name).HasColumnName("NOME_USU");
            builder.Property(u => u.NormalizedEmail).HasColumnName("EMAIL_NORM_USU");
            builder.Property(u => u.NormalizedUserName).HasColumnName("LOGIN_NORM_USU");
            builder.Property(u => u.PasswordHash).HasColumnName("SENHA_USU");
            builder.Property(u => u.SecurityStamp).HasColumnName("SELO_SEGURANCA_USU");
            builder.Property(u => u.TwoFactorEnabled).HasColumnName("TWO_FACTOR_USU");
        }
    }
}
