using System;
namespace infraestructure.Models
{
	public class cuentaModel
	{

		public int idCuenta { get; set; }
		public int idPersona { get; set; }
		public string nombreCuenta { get; set; }
		public string numeroCuenta { get; set; }
		public double saldo { get; set; }
		public double limite { get; set; }
		public string moneda { get; set; }
		public string estado { get; set; }
	}
}