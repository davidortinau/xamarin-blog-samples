using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using RegistrationForm.Pages;
using Xamarin.Forms;

namespace RegistrationForm
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

            MobileCenter.Start(typeof(Analytics), typeof(Crashes));

			NavigationPage mainNav = new NavigationPage(new LoginPage());
			MainPage = mainNav;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
