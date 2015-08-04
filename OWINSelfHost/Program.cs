using System;
using Microsoft.Owin.Hosting;

namespace OWINSelfHost
{
	using Owin;
	class MainClass
	{
		public static void Main (string[] args)
		{
			var url = "http://+:5001";

			using (WebApp.Start<Startup>(url))
			{
				Console.WriteLine("Server Running on {0}", url);
				Console.WriteLine("Press enter to exit");
				Console.ReadLine();
			}
		}
	}
}
