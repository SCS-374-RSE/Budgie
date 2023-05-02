using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Budgie.ViewModels
{
    [QueryProperty(nameof(BudgetName), nameof(BudgetName))]
    [QueryProperty(nameof(BudgetType), nameof(BudgetType))]
    [QueryProperty(nameof(TakeHomeAmt), nameof(TakeHomeAmt))]
    [QueryProperty(nameof(ExpenseTypeOne), nameof(ExpenseTypeOne))]
    [QueryProperty(nameof(ExpenseTypeTwo), nameof(ExpenseTypeTwo))]
    [QueryProperty(nameof(ExpenseTypeThree), nameof(ExpenseTypeThree))]
    [QueryProperty(nameof(ExpenseTypeFour), nameof(ExpenseTypeFour))]
    [QueryProperty(nameof(ExpenseTypeFive), nameof(ExpenseTypeFive))]
    [QueryProperty(nameof(ExpenseCostOne), nameof(ExpenseCostOne))]
    [QueryProperty(nameof(ExpenseCostOne), nameof(ExpenseCostOne))]
    [QueryProperty(nameof(ExpenseCostTwo), nameof(ExpenseCostTwo))]
    [QueryProperty(nameof(ExpenseCostThree), nameof(ExpenseCostThree))]
    [QueryProperty(nameof(ExpenseCostFour), nameof(ExpenseCostFour))]
    [QueryProperty(nameof(ExpenseCostFive), nameof(ExpenseCostFive))]
    [QueryProperty(nameof(Remainder), nameof(Remainder))]

    public partial class ViewPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string budgetName;

        [ObservableProperty]
        string budgetType;

        [ObservableProperty]
        int takeHomeAmt;

        [ObservableProperty]
        string expenseTypeOne;

        [ObservableProperty]
        string expenseTypeTwo;

        [ObservableProperty]
        string expenseTypeThree;

        [ObservableProperty]
        string expenseTypeFour;

        [ObservableProperty]
        string expenseTypeFive;

        [ObservableProperty]
        int expenseCostOne;

        [ObservableProperty]
        int expenseCostTwo;

        [ObservableProperty]
        int expenseCostThree;

        [ObservableProperty]
        int expenseCostFour;

        [ObservableProperty]
        int expenseCostFive;

        [ObservableProperty]
        int remainder;
    }
}

