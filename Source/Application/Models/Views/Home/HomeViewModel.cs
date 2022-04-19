using System;

namespace Application.Models.Views.Home
{
	public class HomeViewModel
	{
		#region Fields

		private Form _form;

		#endregion

		#region Properties

		public virtual Exception Exception { get; set; }

		public virtual Form Form
		{
			get => this._form ??= new Form();
			set => this._form = value;
		}

		public virtual TcpClientResult Result { get; set; }

		#endregion
	}
}