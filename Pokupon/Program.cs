using Pokupon.Views;

namespace Pokupon;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new LoginForm());
	}
}