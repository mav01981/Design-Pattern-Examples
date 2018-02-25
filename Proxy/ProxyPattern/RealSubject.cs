using System;

namespace ProxyPattern
{
	/// <summary>
	/// The real subject class. This is the object being proxied.
	/// </summary>
	class RealSubject : Subject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProxyPattern.RealSubject"/> class.
		/// </summary>
		public RealSubject()
		{
			Console.WriteLine ("RealSubject.ctor()");
		}

		/// <summary>
		/// Make a request.
		/// </summary>
		public override void Request()
		{
			Console.WriteLine("RealSubject.Request()");
		}
	}
	
}
