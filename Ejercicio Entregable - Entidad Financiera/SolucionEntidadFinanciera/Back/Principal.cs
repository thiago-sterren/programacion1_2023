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
            tc.estado = TarjetaCredito.Estado.Pausada;
            context.SaveChanges();
        }
        public void CrearCuentaBancaria(CuentaBancaria cb)
        {
            context.Cuentas.Add(cb);
            context.SaveChanges();
        }
        public void RealizarDeposito(int nroCuenta, double Monto)
        {
            CuentaBancaria? cb = context.Cuentas.Find(nroCuenta);
            if (cb != null)
            {
                cb.saldo += Monto;
                context.SaveChanges();
            }
        }
        public void RealizarExtraccion(int nroCuenta, double Monto)
        {
            CuentaBancaria? cb = context.Cuentas.Find(nroCuenta);
            if (cb != null && cb.saldo >= Monto)
            {
                cb.saldo -= Monto;
                context.SaveChanges();
            }
        }
        public void RealizarTransferencia(int nroCuentaEmisor, int nroCuentaReceptor, double Monto)
        {
            CuentaBancaria? cbEmisor = context.Cuentas.Find(nroCuentaEmisor);
            CuentaBancaria? cbReceptor = context.Cuentas.Find(nroCuentaReceptor);
            if (cbEmisor != null && cbReceptor != null && cbEmisor.saldo >= Monto)
            {
                cbEmisor.saldo -= Monto;
                cbReceptor.saldo += Monto;
                context.SaveChanges();
            }
        }
        public void PagarTarjetaCredito(TarjetaCredito tc, double Monto)
        {
            // no supe como hacerlo
            context.SaveChanges();
        }
        public string GenerarResumenTarjeta(TarjetaCredito tc)
        {
            // no estoy seguro de que ésto sea lo que piden que haga el método
            return $"Número de tarjeta: {tc.numeroTarjeta}. Límite de crédito: {tc.limiteCredito}. Saldo disponible: {tc.saldoDisponible}. Estado: {tc.estado}.";
        }
    }
}