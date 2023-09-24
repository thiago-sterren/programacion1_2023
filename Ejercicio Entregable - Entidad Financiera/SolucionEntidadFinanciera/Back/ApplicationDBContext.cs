using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-767BTASL;database=EntidadFinanciera;trusted_connection=true;Encrypt=False");
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> Cuentas { get; set; }
        public DbSet<TarjetaCredito> Tarjetas { get; set; }
    }
}
