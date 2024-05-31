
namespace MoneyManagement.Views;

public partial class BudgetView : ContentPage
{
	public BudgetView()
	{
		InitializeComponent();
        LoadBudgetSummary();

    }

    private void LoadBudgetSummary()
    {
        // Dummy implementation - You would replace this with your actual logic to load budget summary
        // For demonstration purposes, let's assume we have some dummy budget summary data
        var budgetSummaryData = GetDummyBudgetSummaryData();

        // Clear any existing views from the container
        BudgetSummaryContainer.Children.Clear();

        // Add budget summary details dynamically
        foreach (var item in budgetSummaryData)
        {
            var label = new Label
            {
                Text = $"{item.Category}: {item.Amount:C}",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                Margin = new Thickness(0, 5, 0, 0)
            };

            BudgetSummaryContainer.Children.Add(label);
        }
    }

    // Dummy method to get some budget summary data
    private List<(string Category, decimal Amount)> GetDummyBudgetSummaryData()
    {
        return new List<(string, decimal)>
            {
                ("Food", 500),
                ("Transportation", 200),
                ("Utilities", 300)
                // Add more dummy data as needed
            };
    }

    private async void AddEditBudgetButton_Clicked(object sender, EventArgs e)
    {
        // Logic to navigate to the page where user can add/edit budget
        await Navigation.PushAsync(new BudgetPage());
    }
}