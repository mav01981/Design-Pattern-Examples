using System;

namespace ProxyPattern
{
	/// <summary>
	/// The client class.
	/// </summary>
	public class Client
	{
		/// <summary>
		/// Execute the client.
		/// </summary>
		public void Execute ()
		{
			// use proxy to make a request
			Proxy proxy = new Proxy ();
			proxy.Request ();
		}
	}
}

