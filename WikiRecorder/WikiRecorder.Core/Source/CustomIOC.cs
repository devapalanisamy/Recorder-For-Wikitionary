using System;
using Autofac.Core;
using Autofac;

namespace WikiRecorder.Core
{
	public class CustomIOC
	{
		public static IContainer container;
		public CustomIOC ()
		{
			
		}

		public void createContainer()
		{
			var builder = new ContainerBuilder ();
			builder.RegisterType<FakeWebservice>().As<IWebService>();
			container = builder.Build();

		}
	}
}

