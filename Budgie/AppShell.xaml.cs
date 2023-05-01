namespace Budgie;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ViewBudgetPage), typeof(ViewBudgetPage));
	}

}

