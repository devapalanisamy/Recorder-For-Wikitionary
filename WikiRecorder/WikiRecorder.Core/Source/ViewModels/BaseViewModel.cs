using System;

namespace WikiRecorder.Core
{
	public class BaseViewModel
	{
		protected IWebService webservice = TinyIoC.TinyIoCContainer.Current.Resolve<IWebService>();

		public BaseViewModel ()
		{
			
		}
	}
}

