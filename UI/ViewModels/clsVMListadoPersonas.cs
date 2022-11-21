using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models;
using UI.ViewModels.Utilities;

namespace UI.ViewModels
{
	public class clsVMListadoPersonas
	{

		private ObservableCollection<clsPersonasConDepartamento> personas;

		private clsPersona personaSeleccionada;

		private DelegateCommand insert_Command;

		private DelegateCommand edit_Command;

		private DelegateCommand delete_Command;



		public ObservableCollection<clsPersonasConDepartamento> Personas { get { return personas; } set { personas = value; } }
		
		public clsPersona PersonaSeleccionada { get { return personaSeleccionada; } set { personaSeleccionada = value;  } }



	}
}
