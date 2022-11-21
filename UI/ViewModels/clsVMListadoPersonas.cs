using BL.Listados;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models;
using UI.ViewModels.Utilities;

namespace UI.ViewModels
{
	public class clsVMListadoPersonas : clsVMBase
	{
		#region Atributos
		private ObservableCollection<clsPersonasConDepartamento> personas;

		private clsPersonasConDepartamento personaSeleccionada;

		private DelegateCommand insert_Command;

		private DelegateCommand edit_Command;

		private DelegateCommand delete_Command;
		#endregion

		#region Propiedades

		public ObservableCollection<clsPersonasConDepartamento> Personas { get { return personas; } set { personas = value; } }

		public clsPersonasConDepartamento PersonaSeleccionada
		{
			get
			{
				return personaSeleccionada;
			}
			set
			{
				personaSeleccionada = value;
				NotifyPropertyChanged(nameof(PersonaSeleccionada));
			}
		}

		public DelegateCommand Insert_Command
		{
			get
			{
				insert_Command = new DelegateCommand(InsertCommand_Executed, InsertCommand_CanExecute);
				return insert_Command;
			}
		}

		public DelegateCommand Edit_Command
		{
			get
			{
				insert_Command = new DelegateCommand(EditCommand_Executed, EditCommand_CanExecute);
				return insert_Command;
			}
		}

		public DelegateCommand Delete_Command
		{
			get
			{
				insert_Command = new DelegateCommand(DeleteCommand_Executed, DeleteCommand_CanExecute);
				return insert_Command;
			}
		}

		#endregion


		#region Constructores

		public clsVMListadoPersonas()
		{
			clsListadoPersonasBL personasBL = new();
			clsListadoDepartamentosBL departamentosBL = new();
			ObservableCollection<clsDepartamento> departamentos = departamentosBL.getListadoDepartamentosBL();
			Personas = new ObservableCollection<clsPersonasConDepartamento>();
			foreach (clsPersona p in personasBL.getListadoCompletoPersonasBL())
			{

				for (int i = 0; i < departamentos.Count; i++)
				{

					if (departamentos.ElementAt(i).Id == p.IdDepartamento)
					{

						Personas.Add( new(p.Nombre, p.Apellidos, p.Telefono, p.Direccion, p.FechaNacimiento, departamentos.ElementAt(i).Nombre));

					}
				}
			}

		}

		#endregion


		#region CommandImplementation
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		private bool EditCommand_CanExecute()
		{
			throw new NotImplementedException();
		}

		private void EditCommand_Executed()
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		private bool DeleteCommand_CanExecute()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private void DeleteCommand_Executed()
		{
			throw new NotImplementedException();
		}





		/// <summary>
		/// Método que 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		private bool InsertCommand_CanExecute()
		{

			throw new NotImplementedException();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private void InsertCommand_Executed()
		{
			throw new NotImplementedException();
		}



		#endregion











	}
}
