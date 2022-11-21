using DAL.Conexion;
using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Gestion
{
	public class clsGestionPersonas
	{
		private clsMiConexion miConexion;

		public bool insertarPersona(clsPersona persona)
		{
			var exito = false;
			miConexion = new clsMiConexion();
			SqlConnection cnn = miConexion.getConnection();
			SqlCommand comando = new SqlCommand();
			comando.Connection = cnn;
			comando.CommandText = "Insert into personas values(@nombre, @apellidos, @telefono, @direccion, @fechaNac, @idDepartamento)";
			comando.Parameters.AddWithValue("@nombre", persona.Nombre);
			comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
			comando.Parameters.AddWithValue("@telefono", persona.Telefono);
			comando.Parameters.AddWithValue("@direccion", persona.Direccion);
			comando.Parameters.AddWithValue("@idDepartamento", persona.IdDepartamento);
			if (comando.ExecuteNonQuery() > 0)
			{
				exito = true;
			}
			return exito;
		}
	}
}
