using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
	public class clsPersonasConDepartamento : clsPersona
	{
		private string nombreDepartamento;

		public string NombreDepartamento { get; set; }

		public clsPersonasConDepartamento(string _nombre, string _apellidos, string _telefono, string _direccion, DateTime _fechaNacimiento, string nombreDepartamento)
		{
			
			base.Nombre = _nombre;
			base.Apellidos = _apellidos;
			base.Direccion = _direccion;
			base.Telefono = _telefono;
			base.FechaNacimiento = _fechaNacimiento;
			NombreDepartamento = nombreDepartamento;

		}

		public clsPersonasConDepartamento()
		{
		}
	}
}
