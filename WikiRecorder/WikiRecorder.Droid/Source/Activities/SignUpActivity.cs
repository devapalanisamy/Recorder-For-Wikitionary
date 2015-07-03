
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WikiRecorder.Droid
{
	[Activity(Label = "SignUpActivity" , MainLauncher=true)]			
	public class SignUpActivity : BaseActivity
	{
		public override BaseFragment GetFragment()
		{
			return new SignUpFragment ();
		}	
	}
}

