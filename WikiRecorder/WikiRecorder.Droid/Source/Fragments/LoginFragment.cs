﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace WikiRecorder.Droid
{
	public class LoginFragment : BaseFragment
	{

		public override int GetLayOutId()
		{
			return Resource.Layout.LoginLayout;
		}
			
	}
}

