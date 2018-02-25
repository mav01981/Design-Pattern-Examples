using System;

namespace HtmlRenderExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// create a simple html document
			var html = new Html ();
			var body = new Body ();
			var p = new P ();
			var text = new Text ("Hello World");
			p.AddChild (text);
			body.AddChild (p);
			html.AddChild (body);

			// render the document to the console
			Console.WriteLine (html.Render ());
		}
	}
}
