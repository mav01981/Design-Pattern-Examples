using System;

namespace BitcoinExample
{
	/// <summary>
	/// The abstract subject base class.
	/// </summary>
	abstract class CoinApi
	{
		/// <summary>
		/// Get the value of one coin in USD.
		/// </summary>
		public abstract decimal GetValueInUSD();
	}
	
}
