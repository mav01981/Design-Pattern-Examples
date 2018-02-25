using System;

namespace ProxyPattern
{
	/// <summary>
	/// The proxy class.
	/// </summary>
	class Proxy : Subject
	{
		// the reference to the real subject
		private RealSubject _realSubject;

		/// <summary>
		/// Make a request.
		/// </summary>
		public override void Request()
		{
			Console.WriteLine ("Proxy.Request starting...");

			// this is a virtual proxy - we use lazy instantiation
			if (_realSubject == null)
			{
				_realSubject = new RealSubject();
			}
			_realSubject.Request();
		}
	}
	
}
