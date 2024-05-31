using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace MoneyManagementApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand NavigateToAddIncomeCommand { get; private set; }
        public ICommand NavigateToAddExpenseCommand { get; private set; }

        public MainViewModel()
        {
            NavigateToAddIncomeCommand = new Command(NavigateToAddIncome);
            NavigateToAddExpenseCommand = new Command(NavigateToAddExpense);
        }

        private void NavigateToAddIncome()
        {
            // Logic to navigate to the Add Income page goes here
        }

        private void NavigateToAddExpense()
        {
            // Logic to navigate to the Add Expense page goes here
        }
    }
}
