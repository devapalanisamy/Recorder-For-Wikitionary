﻿
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
	[Activity(Label = "LoginActivity" ,MainLauncher=true)]			
	public class LoginActivity : BaseActivity
	{

		public override BaseFragment GetFragment()
		{
			return new LoginFragment ();
		}

	}
}

