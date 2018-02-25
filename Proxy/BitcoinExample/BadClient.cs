using System;
using System.Threading;

namespace BitcoinExample
{
	/// <summary>
	/// The client class.
	/// </summary>
	public class BadClient
	{
		/// <summary>
		/// Execute the client.
		/// </summary>
		public void Execute ()
		{
			// instantiate bitcoin api with rate limiter
			var service = 
				new WithRateLimit (
				new BitcoinApi ());

			// get value of bitcoin every 100ms
			for (int i=0; i<21; i++)
			{
				try 
				{
					Console.WriteLine(service.GetValueInUSD());
				}
				catch(Exception ex)
				{
					Console.WriteLine (ex.Message);
				}
				Thread.Sleep (100);
			}
		}
	}
}

