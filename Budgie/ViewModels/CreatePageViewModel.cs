using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Budgie.ViewModels
{
    public partial class CreatePageViewModel : INotifyPropertyChanged
    {       
        public CreatePageViewModel()
        {
            SubmitFormCommand = new Command(OnFormSubmission);            
        }

        public ICommand SubmitFormCommand { get; }

        // Input from the create page
        public string budgetName { get; set; }
        public int takeHomeAmt { get; set; }
        public string budgetType { get; set; }

        public string expenseTypeOne { get; set; }
        public string expenseTypeTwo { get; set; }
        public string expenseTypeThree { get; set; }
        public string expenseTypeFour { get; set; }
        public string expenseTypeFive { get; set; }

        public int expenseCostOne { get; set; }
        public int expenseCostTwo { get; set; }
        public int expenseCostThree { get; set; }
        public int expenseCostFour { get; set; }
        public int expenseCostFive { get; set; }

        Task Navigate() =>
            Shell.Current.GoToAsync($"{nameof(ViewBudgetPage)}?BudgetName={budgetName}");

        // Calculations using data from the create page
        public int remainder { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void OnFormSubmission()
        {
            Navigate();
            remainder = takeHomeAmt - expenseCostOne - expenseCostTwo - expenseCostThree - expenseCostFour - expenseCostFive;

            // Still need to somehow send variable data to view page before resetting the values

            // Reset input fields
            budgetName = "";
            takeHomeAmt = 0;
            budgetType = "";
            expenseTypeOne = "";
            expenseTypeTwo = "";
            expenseTypeThree = "";
            expenseTypeFour = "";
            expenseTypeFive = "";
            expenseCostOne = 0;
            expenseCostTwo = 0;
            expenseCostThree = 0;
            expenseCostFour = 0;
            expenseCostFive = 0;
            OnPropertyChanged(nameof(budgetName));
            OnPropertyChanged(nameof(takeHomeAmt));
            OnPropertyChanged(nameof(budgetType));
            OnPropertyChanged(nameof(expenseTypeOne));
            OnPropertyChanged(nameof(expenseTypeTwo));
            OnPropertyChanged(nameof(expenseTypeThree));
            OnPropertyChanged(nameof(expenseTypeFour));
            OnPropertyChanged(nameof(expenseTypeFive));
            OnPropertyChanged(nameof(expenseCostOne));
            OnPropertyChanged(nameof(expenseCostTwo));
            OnPropertyChanged(nameof(expenseCostThree));
            OnPropertyChanged(nameof(expenseCostFour));
            OnPropertyChanged(nameof(expenseCostFive));
        }
    }
}

