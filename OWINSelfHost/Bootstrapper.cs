using System;
using Nancy;
using Nancy.Conventions;

namespace OWINSelfHost
{

	public class Bootstrapper : DefaultNancyBootstrapper
	{

		protected override void ConfigureConventions(NancyConventions nancyConventions)
		{
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts", @"Scripts"));
			nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Fonts", @"Fonts"));
			base.ConfigureConventions(nancyConventions);
		}

		protected override IRootPathProvider RootPathProvider {
			get { return new ServiceRootProvider(); }
		}
	}
}

