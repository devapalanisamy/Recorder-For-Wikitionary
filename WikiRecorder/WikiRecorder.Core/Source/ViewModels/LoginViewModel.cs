using System;

namespace WikiRecorder.Core
{
	public class LoginViewModel: BaseViewModel
	{
		public LoginViewModel ()
		{
		}

		public string UserName{ get; set; }
		public string Password{ get; set; }

		public async string LoginButtonTapped()
		{
			if (string.IsNullOrEmpty(UserName))
				throw new Exception ("Username is blank");

			if (string.IsNullOrEmpty(Password))
				throw new Exception ("Password is blank");
				
			IsBusy = true;
			try
			{
				string userId =  await webservice.Login(UserName, Password);
			}
			finally {
				IsBusy = false;
			}
		}
	}
}

