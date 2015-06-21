using System;

namespace WikiRecorder.Core
{
	public class BaseViewModel
	{
		protected IWebService webservice = TinyIoC.TinyIoCContainer.Current.Resolve<IWebService>();

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
			
		}
	}
}

