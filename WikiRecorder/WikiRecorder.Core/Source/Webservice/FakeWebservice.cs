using System;
using System.Threading.Tasks;

namespace WikiRecorder.Core
{
	public class FakeWebservice:IWebService
	{

		public int SleepDuration { get; set; }
		public FakeWebservice ()
		{
			SleepDuration = 2;
		}

		private Task Sleep()
		{
			return Task.Delay(SleepDuration);
		}

			
		public async Task<string> Login(string userName, string password)
		{
			await Sleep();
			return "sessionId";
		}

		public  async Task<string> Register(string userName, string emailId, string password, string confirmPassword)
		{
			await Sleep();
			return "userId";
		}

		public  async Task<string> Upload(string baseUrl, string filePath)
		{
			await Sleep();
			return "URL";
		}

		public  async Task<string> GetToken(string userName, string password)
		{
			await Sleep();
			return "token";
		}

		public  async Task<string> EditPage(string wikiContentUrl, string contentString)
		{
			await Sleep();
			return "editStatus";
		}

	}
}

