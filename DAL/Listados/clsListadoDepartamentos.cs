using DAL.Conexion;
using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Listados
{
	public class clsListadoDepartamentos
	{

		private clsMiConexion miConexion = new clsMiConexion();


		/// <summary>
		/// Función que se encarga de recoger un listado de objetos clsDepartamento de la base de datos
		/// introducida en la instancia del objeto clsMiConexion.
		/// 
		/// </summary>
		/// <returns></returns>
		public List<clsDepartamento> getListadoCompletoDepartamentos()
		{
			List<clsDepartamento> lista = new List<clsDepartamento>();	
			SqlConnection cnn = miConexion.getConnection();
			SqlCommand cmd = cnn.CreateCommand();
			SqlDataReader miLector;
			cmd.Connection = cnn;

			cmd.CommandText = "Select * From departamentos";
			miLector = cmd.ExecuteReader();
			while (miLector.Read())
			{
				if (miLector.HasRows)
				{
					clsDepartamento departamento = new clsDepartamento();
					departamento.Id = miLector.GetInt16(1);
					departamento.Nombre = miLector.GetString(2);
					lista.Add(departamento);
				}
			}
			return lista;
		}
	}
}
