using DAL.Listados;
using Entities;
using System.Collections.ObjectModel;


namespace BL.Listados
{
	public class clsListadoDepartamentosBL
	{

		clsListadoDepartamentos dal;

		public ObservableCollection<clsDepartamento> getListadoDepartamentosBL()
		{
			dal = new clsListadoDepartamentos();
			ObservableCollection<clsDepartamento> lista = new ObservableCollection<clsDepartamento>();
			foreach(var departamento in dal.getListadoCompletoDepartamentos())
			{
				lista.Add(departamento);
			}
			return lista;
		}
	}
}
