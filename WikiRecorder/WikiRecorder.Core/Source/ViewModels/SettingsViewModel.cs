using System;
using System.Collections.Generic;

namespace WikiRecorder.Core
{
	public class SettingsViewModel: BaseViewModel
	{
		public string UserName {
			get;
			set;
		}

		public string SelectedLanguage {
			get;
			set;
		}

		public List<string> GetAvailableLanguages()
		{
			//get languages from parse
			return new List<string>();
		}

		public SettingsViewModel ()
		{
		}
	}
}

