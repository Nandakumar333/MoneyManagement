
namespace MoneyManagement.Views;

public partial class HomeView : ContentPage
{
    public HomeView()
    {
        InitializeComponent();
        UpdateBalance(); // Call method to update balance when the view is initialized
    }

    private void UpdateBalance()
    {
        // Example: Fetch the user's balance from the database or any other source
        decimal balance = FetchUserBalance();

        // Update the BalanceLabel text to display the balance
        BalanceLabel.Text = balance.ToString("C"); // Format as currency
    }

    // Example method to fetch user's balance from the database
    private decimal FetchUserBalance()
    {
        // You would implement logic to fetch the user's balance from the database or any other source here
        // For demonstration purposes, let's assume the balance is fetched from a hypothetical method GetBalanceFromDatabase()
        return GetBalanceFromDatabase();
    }

    private decimal GetBalanceFromDatabase()
    {
        // Example implementation to return a hardcoded balance for demonstration purposes
        return 5000.00m; // Assuming the balance is $5000.00
    }

    private async void ViewTransactionsButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the TransactionsView when the "View Transactions" button is clicked
        await Navigation.PushAsync(new TransactionsView());
    }

    private async void AddExpenseButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the AddExpensePage when the "Add Expense" button is clicked
        await Navigation.PushAsync(new AddExpensePage());
    }

    private async void AddIncomeButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the AddIncomePage when the "Add Income" button is clicked
        await Navigation.PushAsync(new AddIncomePage());
    }
    private async void BudgetButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the AddIncomePage when the "Add Income" button is clicked
        await Navigation.PushAsync(new BudgetView());
    }
}