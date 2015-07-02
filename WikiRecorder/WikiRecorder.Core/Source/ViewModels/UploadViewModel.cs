using System;
using System.Collections.Generic;

namespace WikiRecorder.Core
{
	public class UploadViewModel:BaseViewModel
	{
		public List<string> RecordedFileNames {
			get;
			set;
		}

		public Dictionary<string,bool> UploadStatuses {
			get;
			set;
		}

		public string UploadButtonTitle {
			get;
			set;
		}


		public UploadViewModel ()
		{
		}
	}
}

