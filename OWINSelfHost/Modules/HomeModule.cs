using System;
using Nancy;

namespace OWINSelfHost
{
	public class HomeModule : NancyModule

	{
		public HomeModule ()
		{
			Get ["/"] = _ => {
				return View["Home.html"];
			};

			Get ["/Feature"] = _ => {
				return View["Feature.html"];
			};

			Get ["/Contact"] = _ => {
				return View["Contact.html"];
			};
		}
	}
}

