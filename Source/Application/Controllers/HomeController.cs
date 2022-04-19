using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Threading.Tasks;
using Application.Models.Views.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Application.Controllers
{
	public class HomeController : Controller
	{
		#region Constructors

		public HomeController(ILoggerFactory loggerFactory)
		{
			this.Logger = (loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory))).CreateLogger(this.GetType());
		}

		#endregion

		#region Properties

		protected internal virtual ILogger Logger { get; }

		#endregion

		#region Methods

		public virtual async Task<IActionResult> Index()
		{
			return await Task.FromResult(this.View(new HomeViewModel()));
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[SuppressMessage("Design", "CA1031:Do not catch general exception types")]
		public virtual async Task<IActionResult> Index(Form form)
		{
			if(form == null)
				throw new ArgumentNullException(nameof(form));

			var model = new HomeViewModel
			{
				Form = form
			};

			try
			{
				using(var tcpClient = new TcpClient(form.Host, form.Port))
				{
					model.Result = new TcpClientResult
					{
						Available = tcpClient.Available,
						Connected = tcpClient.Connected
					};
				}
			}
			catch(Exception exception)
			{
				model.Exception = new InvalidOperationException($"Could not connect to host \"{form.Host}\" on port \"{form.Port}\".", exception);
			}

			return await Task.FromResult(this.View(model));
		}

		#endregion
	}
}