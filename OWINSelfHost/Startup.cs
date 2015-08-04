using Owin;
using Microsoft.Owin.Diagnostics;
using Nancy.Owin;
using Nancy;

namespace OWINSelfHost
{
	public class Startup
	{
		public void Configuration ( IAppBuilder app)
		{
			app.UseWelcomePage ("/owin");
			app.UseNancy ();
		}
	}
}
