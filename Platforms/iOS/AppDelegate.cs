using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace TabbedPageBugDemo
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}