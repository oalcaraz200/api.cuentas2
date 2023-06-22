using System;
using System.Reflection;
using infraestructure.repository;
namespace services.service
{
	public class operacionesService
	{
        cuentaRepository repository;

		public operacionesService(string cadenaConexion)
		{
            cuentaRepository repository = new cuentaRepository(cadenaConexion);
        }

        public bool transferir(operacionMovimientoModel modelo)
        {


            //consultar los datos de las cuentas a operar

            var CuentaOrigen = repository.consultarCuenta(modelo.cuentaOrigen);
            var CuentaDestino = repository.consultarCuenta(modelo.cuentaDestino);

            // validaciones básicas.

            CuentaOrigen.saldo -= modelo.monto;
            CuentaDestino.saldo += modelo.monto;

            repository.modificarCuenta(CuentaOrigen);
            repository.modificarCuenta(CuentaDestino);


            return true;
        }

        public bool depositar(string numeroCuenta, double monto)
        {
            var cuenta = repository.consultarCuenta(numeroCuenta);

            cuenta.saldo += monto;

            repository.modificarCuenta(cuenta);

            return true;
        }

        public bool devolucion(operacionMovimientoModel modelo)
        {
            return true;
        }

        public bool extracto()
        {
            return true;
        }
    }

    public class operacionMovimientoModel {

        public string cuentaOrigen { get; set; } 
        public string cuentaDestino { get; set; }
        public double monto { get; set; }

    }
}

