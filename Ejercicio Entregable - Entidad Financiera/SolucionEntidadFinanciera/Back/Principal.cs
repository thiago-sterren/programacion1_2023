﻿namespace Back
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
        public void PausarTarjetaCredito(int numeroTarjeta)
        {
            TarjetaCredito? tc = context.Tarjetas.Find(numeroTarjeta);
            if (tc != null)
            {
                tc.estado = TarjetaCredito.Estado.Pausada;
                context.SaveChanges();
            }
        }
        public void CrearCuentaBancaria(CuentaBancaria cb)
        {
            context.Cuentas.Add(cb);
            context.SaveChanges();
        }
        public string RealizarDeposito(int nroCuenta, double Monto)
        {
            CuentaBancaria? cb = context.Cuentas.Find(nroCuenta);
            if (cb != null)
            {
                cb.saldo += Monto;
                context.SaveChanges();
                return "Depósito realizado con éxito";
            }
            else
            {
                return "No existe una cuenta bancaria con ese número de cuenta, intente nuevamente";
            }
        }
        public string RealizarExtraccion(int nroCuenta, double Monto)
        {
            CuentaBancaria? cb = context.Cuentas.Find(nroCuenta);
            if (cb != null)
            {
                if (cb.saldo >= Monto)
                {
                    cb.saldo -= Monto;
                    context.SaveChanges();
                    return "Extracción realizada con éxito";
                }
                else
                {
                    return $"El monto que quiere extraer es mayor al saldo de su cuenta bancaria. Su saldo es de ${cb.saldo}";
                }
            }
            else
            {
                return "No existe una cuenta bancaria con ese número de cuenta, intente nuevamente";
            }
        }
        public string RealizarTransferencia(int nroCuentaEmisor, int nroCuentaReceptor, double Monto)
        {
            CuentaBancaria? cbEmisor = context.Cuentas.Find(nroCuentaEmisor);
            CuentaBancaria? cbReceptor = context.Cuentas.Find(nroCuentaReceptor);
            if (cbEmisor != null && cbReceptor != null)
            {
                if (cbEmisor.saldo >= Monto)
                {
                    cbEmisor.saldo -= Monto;
                    cbReceptor.saldo += Monto;
                    context.SaveChanges();
                    return "Transferencia realizada con éxito";
                }
                else
                {
                    return $"El monto que quiere transferir es mayor al saldo de su cuenta bancaria. Su saldo es de ${cbEmisor.saldo}";
                }
            }
            else
            {
                return "Alguno o ambos números de cuenta ingresados no corresponden a cuentas bancarias existentes, intente nuevamente";
            }
        }
        public string PagarTarjetaCredito(int numeroTarjeta, double Monto)
        {
            TarjetaCredito? tc = context.Tarjetas.Find(numeroTarjeta);
            if (tc != null)
            {
                if (tc.MontoDeuda == Monto)
                {
                    tc.MontoDeuda -= Monto;
                    context.SaveChanges();
                    return "Deuda saldada";
                }
                else if (tc.MontoDeuda < Monto)
                {
                    double sobrante = Monto - tc.MontoDeuda;
                    context.SaveChanges();
                    return $"Deuda saldada, se le devuelve el sobrante, que es de ${sobrante}";
                }
                else
                {
                    tc.MontoDeuda -= Monto;
                    context.SaveChanges();
                    return $"Pago aceptado, ahora su deuda ha reducido a ${tc.MontoDeuda}";
                }
            }
            else
            {
                return $"No existe una tarjeta de crédito con el número {numeroTarjeta}";
            }
        }
        public string GenerarResumenTarjeta(TarjetaCredito tc)
        {
            // no estoy seguro de que ésto sea lo que piden que haga el método
            return $"Número de tarjeta: {tc.numeroTarjeta}. Límite de crédito: {tc.limiteCredito}. Saldo disponible: {tc.saldoDisponible}. Estado: {tc.estado}.";
        }
    }
}