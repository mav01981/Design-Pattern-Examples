using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace BitcoinExample
{
	/// <summary>
	/// The real subject class. This is the object being proxied.
	/// </summary>
	class BitcoinApi : CoinApi
	{
		/// <summary>
		/// Get the value of one bitcoin in USD.
		/// </summary>
		/// <returns>The value in US.</returns>
		public override decimal GetValueInUSD()
		{
			// call web service to get bitcoin value
			var request = WebRequest.Create (@"http://coinabul.com/api.php");
			BitcoinResponse json = null;
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				var serializer = new DataContractJsonSerializer(typeof(BitcoinResponse));
				var obj = serializer.ReadObject(response.GetResponseStream());
				json = obj as BitcoinResponse;
			}

			// return value
			return (decimal) (json != null ? json.BTC.USD : 0f);
		}
	}

	/// <summary>
	/// The json response object of the bitcoin service.
	/// </summary>
	[DataContract]
	public class BitcoinResponse
	{
		[DataMember(Name = "BTC")]
		public BTCResponse BTC { get; set; }
	}

	/// <summary>
	/// The json BTC response object of the bitcoin service.
	/// </summary>
	[DataContract]
	public class BTCResponse
	{
		[DataMember(Name = "USD")]
		public float USD { get; set; }
	}

	
}
