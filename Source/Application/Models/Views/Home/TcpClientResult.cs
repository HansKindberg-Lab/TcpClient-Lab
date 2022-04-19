namespace Application.Models.Views.Home
{
	public class TcpClientResult
	{
		#region Properties

		/// <summary>
		/// Gets the amount of data pending in the network's input buffer that can be read from the socket.
		/// </summary>
		public virtual int Available { get; set; }

		/// <summary>
		/// Gets the connection state of the Socket. This property will return the latest known state of the Socket. When it returns false, the Socket was either never connected or it is not connected anymore. When it returns true, though, there's no guarantee that the Socket is still connected, but only that it was connected at the time of the last IO operation.
		/// </summary>
		public virtual bool Connected { get; set; }

		#endregion
	}
}