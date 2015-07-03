
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
	public abstract class BaseActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			FragmentManager fragmentManager = this.FragmentManager;
			BaseFragment fragment = fragmentManager.FindFragmentByTag("aSADDSA") as BaseFragment;   
			if (fragment == null) {
				FragmentTransaction fragmentTransaction = fragmentManager.BeginTransaction();
				fragment = GetFragment();
				fragmentTransaction.Replace(Resource.Id.superContainer, fragment,"hello");
				fragmentTransaction.Commit();
			}
		}

		public abstract BaseFragment GetFragment();
	}
}

