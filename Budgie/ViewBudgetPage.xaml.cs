using Budgie.ViewModels;

namespace Budgie;

public partial class ViewBudgetPage : ContentPage
{
	public ViewBudgetPage()
	{
		InitializeComponent();
		BindingContext = new ViewPageViewModel();
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}
}
