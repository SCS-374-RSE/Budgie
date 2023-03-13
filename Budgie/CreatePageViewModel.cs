using System;
using System.ComponentModel;
using System.Windows.Input;
namespace Budgie
{
    public class CreatePageViewModel : INotifyPropertyChanged
    {
        public CreatePageViewModel()
        {
            SubmitFormCommand = new Command(OnFormSubmission);
        }

        public ICommand SubmitFormCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

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

        public void OnFormSubmission()
        {
            budgetName.ToLower();
        }
    }
}

