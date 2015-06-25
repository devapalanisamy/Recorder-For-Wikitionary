using System;
using System.Threading.Tasks;

namespace WikiRecorder.Core
{
	public class RegisterViewModel:BaseViewModel
	{
		public RegisterViewModel ()
		{
		}

		public string UserName{ get; set;}
		public string EmailId{ get; set;}
		public string Password{ get; set;}
		public string ConfirmPassword{ get; set;}

		public async Task<string> RegisterButtonTapped()
		{
			if (string.IsNullOrEmpty(UserName))
				throw new Exception ("Username is blank");

			if (string.IsNullOrEmpty(EmailId))
				throw new Exception ("EmailId is blank");

			if (string.IsNullOrEmpty(Password))
				throw new Exception ("Password is blank");

			if (string.IsNullOrEmpty(ConfirmPassword))
				throw new Exception ("Password is blank");

			IsBusy = true;
			string userId = "";
			try
			{
				userId = await webservice.Register(UserName,EmailId,Password,ConfirmPassword);
			}
			finally {
				IsBusy = false;
			}

			return userId;
		}
	}
}

