using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Budgie.ViewModels
{
    [QueryProperty(nameof(BudgetName), nameof(BudgetName))]

    public partial class ViewPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string budgetName;
    }
}

