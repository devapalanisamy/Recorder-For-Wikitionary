using System;
using Autofac;

namespace WikiRecorder.Core
{
	public class BaseViewModel
	{
		//protected IWebService webservice = TinyIoC.TinyIoCContainer.Current.Resolve<IWebService>();

		protected IWebService webservice ;


		private bool isBusy = false;

		public bool IsBusy {
			get{
				return isBusy;
			}
			set{
				isBusy = value;
				IsBusyChanged(this, EventArgs.Empty);
			}
		}

		private event EventHandler IsBusyChanged = delegate {};

		public BaseViewModel ()
		{
			CustomIOC customIOC = new CustomIOC ();
			customIOC.createContainer();
			webservice = CustomIOC.container.Resolve<IWebService>();
		}
	}
}

