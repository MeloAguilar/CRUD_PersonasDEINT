using DAL.Listados;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Listados
{
	public class clsListadoPersonasBL
	{
		clsListadoPersonas dal;

		public ObservableCollection<clsPersona> getListadoCompletoPersonasBL()
		{
			dal = new clsListadoPersonas();
			ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>();
			foreach(clsPersona clsPersona in dal.getListadoCompletoPersonas())
			{
				personas.Add(clsPersona);
			}


			return personas;
		}
	}
}
