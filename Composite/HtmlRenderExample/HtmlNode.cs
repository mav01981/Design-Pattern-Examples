using System;

namespace HtmlRenderExample
{
	/// <summary>
	/// The component abstract base class.
	/// </summary>
	public abstract class HtmlNode
	{
		/// <summary>
		/// Render the HTML node.
		/// </summary>
		public abstract string Render();
	}
	
}
