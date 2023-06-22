using System;
using infraestructure.repository;

namespace services.service
{
	public class cuentaService
	{
        private cuentaRepository repository;

        public cuentaService(string CadenaConexion)
		{
            repository = new cuentaRepository(CadenaConexion);
		}

        public bool insertarCuenta()
        {
            return true;
        }

        public bool modificarCuenta()
        {
            return true;
        }

        public bool eliminarCuenta()
        {
            return true;
        }

        public infraestructure.Models.cuentaModel consultarCuenta(string numeroCuenta)
        {
            return repository.consultarCuenta(numeroCuenta);
        }

        public List<string> listarCuentas()
        {
            return null;
        }
    }
}

