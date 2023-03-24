using Budgie.ViewModels;

namespace Budgie;

public partial class CreateBudgetPage : ContentPage
{
    public CreateBudgetPage()
    {
        InitializeComponent();
        BindingContext = new CreatePageViewModel();
    }
}
