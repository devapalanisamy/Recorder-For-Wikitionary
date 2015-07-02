
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
	[Activity(Label = "BaseActivity")]			
	public class BaseActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);
			FragmentManager fm = this.FragmentManager;
			Fragment fragment = fm.FindFragmentByTag("aSADDSA");   
			if (fragment == null) {
				FragmentTransaction ft = fm.BeginTransaction();
				fragment = new SignUpFragment ();
				ft.Add(Resource.Id.superContainer, fragment,"hello");
				ft.Commit();
			}
		}
	}
}

