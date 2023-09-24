namespace Back
{
    public class Principal
    {
        ApplicationDBContext context = new ApplicationDBContext();
        public void AgregarCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
        public void EmitirTarjetaCredito(TarjetaCredito tc)
        {
            context.Tarjetas.Add(tc);
            context.SaveChanges();
        }
        public void PausarTarjetaCredito(TarjetaCredito tc)
        {
            context.Tarjetas.Remove(tc);
            context.SaveChanges();
        }
        public void CrearCuentaBancaria(CuentaBancaria cb)
        {
            context.Cuentas.Add(cb);
            context.SaveChanges();
        }
        public void RealizarDeposito(CuentaBancaria cb, double Monto)
        {
            cb.saldo += Monto;
        }
        public void RealizarExtraccion(CuentaBancaria cb, double Monto)
        {
            cb.saldo -= Monto;
        }
        public void RealizarTransferencia(CuentaBancaria emisor, CuentaBancaria receptor, double Monto)
        {
            emisor.saldo -= Monto;
            receptor.saldo += Monto;
            context.SaveChanges();
        }
        public void PagarTarjetaCredito(TarjetaCredito tc, double Monto)
        {
            context.SaveChanges();
        }
        public void GenerarResumenTarjeta(TarjetaCredito tc)
        {   
            context.SaveChanges();
        }
    }
}