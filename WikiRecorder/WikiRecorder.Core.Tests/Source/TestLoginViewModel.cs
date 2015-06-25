using System;
using NUnit.Framework;

namespace WikiRecorder.Core.Tests
{
	public class TestLoginViewModel
	{
		public TestLoginViewModel ()
		{
		}
		[Test()]
		public async void TestLogin()
		{
			LoginViewModel loginViewModel1 = new LoginViewModel ();
			loginViewModel1.UserName = "Deva";
			loginViewModel1.Password = "password";
			Console.WriteLine("Login ID returns: " + await loginViewModel1.LoginButtonTapped());
			Assert.AreEqual("sessionId", await loginViewModel1.LoginButtonTapped());
		}
	}
}

