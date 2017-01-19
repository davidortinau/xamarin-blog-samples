using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Azure.Mobile;
using UIKit;

namespace RegistrationForm.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

            MobileCenter.Configure("1c5f1d59-2886-4430-85d9-d92dd64825bd");

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
