using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Convert.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convert.Android.Views
{
    [Activity(Label = "@string/app_name", MainLauncher = true, NoHistory = true)]
    public class SplashScreenView : MvxSplashScreenActivity
    {
        public SplashScreenView()
            : base(Resource.Layout.SplashScreenView)
        {

        }
    }
}