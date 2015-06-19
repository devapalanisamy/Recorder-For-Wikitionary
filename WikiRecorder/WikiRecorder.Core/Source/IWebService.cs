using System;
using System.Threading.Tasks;

namespace WikiRecorder.Core
{
	public interface IWebService
	{
		Task<string> Login(string userName, string password);
		Task<string> Register(string userName, string emailId, string password, string confirmPassword);
		Task<string> Upload(string baseUrl, string filePath);
		Task<string> GetToken(string userName, string password);
		Task<string> EditPage(string wikiContentUrl, string contentString);
	}
}

