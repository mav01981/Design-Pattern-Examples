using System;

namespace BitcoinExample
{
	/// <summary>
	/// The proxy class.
	/// </summary>
	class WithRateLimit : CoinApi
	{
		// the reference to the real subject
		private CoinApi _realSubject;

		// the date and time when the web service was last called
		DateTime lastCalled = DateTime.MinValue;

		/// <summary>
		/// Initializes a new instance of the <see cref="BitcoinExample.WithRateLimit"/> class.
		/// </summary>
		/// <param name="realSubject">Real subject.</param>
		public WithRateLimit(CoinApi realSubject)
		{
			_realSubject = realSubject;
		}

		/// <summary>
		/// Get the value of one coin in USD.
		/// </summary>
		/// <returns>The value in US.</returns>
		public override decimal GetValueInUSD()
		{
			// throw exception if too soon
			if (DateTime.Now - lastCalled < TimeSpan.FromSeconds (1))
			{
				throw new InvalidOperationException ("Rate limit exceeded");
			} else
			{
				var value = _realSubject.GetValueInUSD();
				lastCalled = DateTime.Now;
				return value;
			}
		}
	}
	
}
