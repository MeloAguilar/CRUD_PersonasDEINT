using DAL.Conexion;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL.Listados
{
	public class clsListadoPersonas
	{
		clsMiConexion miConexion = new clsMiConexion();


		/// <summary>
		/// Método que se encarga de rellenar una lista de objetos tipo clsPersona
		/// a partir de una llamada a la base de datos.
		/// 
		/// </summary>
		/// <returns></returns>
		public List<clsPersona> getListadoCompletoPersonas() {

			List<clsPersona> lista = new List<clsPersona>();

			SqlConnection cnn = miConexion.getConnection();
			SqlCommand cmd = new SqlCommand();
			SqlDataReader miLector;
			
			cmd.CommandText = "Select * From Personas";

			cmd.Connection = cnn;
			miLector = cmd.ExecuteReader();
			if (miLector.HasRows)
			{

				while (miLector.Read())
				{
					lista.Add(new clsPersona(miLector.GetInt16(1), miLector.GetString(2), miLector.GetString(3), miLector.GetString(4), miLector.GetString(5), miLector.GetString(6), miLector.GetDateTime(7), miLector.GetInt16(8)));

				}
			}




			return lista;

		}
	}
}
