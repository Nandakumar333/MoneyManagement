namespace MoneyManagement.Views;

public partial class AddExpensePage : ContentPage
{
	public AddExpensePage()
	{
		InitializeComponent();
	}
    private void OnAddExpenseClicked(object sender, EventArgs e)
    {
        // Validate input fields
        if (string.IsNullOrWhiteSpace(ExpenseAmountEntry.Text))
        {
            DisplayAlert("Error", "Please enter the amount.", "OK");
            return;
        }

        // Convert amount to decimal
        if (!decimal.TryParse(ExpenseAmountEntry.Text, out decimal amount))
        {
            DisplayAlert("Error", "Invalid amount format.", "OK");
            return;
        }

        // Get selected category
        string category = ExpenseCategoryPicker.SelectedItem as string;
        if (string.IsNullOrWhiteSpace(category))
        {
            DisplayAlert("Error", "Please select a category.", "OK");
            return;
        }

        // Get selected date
        DateTime date = ExpenseDate.Date;

        // Get notes
        string notes = ExpenseNotesEditor.Text;

        // Perform the logic to add expense (e.g., save to database, update balance, etc.)
        // You would implement this according to your app's architecture

        // Display success message
        DisplayAlert("Success", "Expense added successfully.", "OK");

        // Navigate back to the previous page or perform any other navigation as needed
        Navigation.PopAsync();
    }

    private async void AddEditCategoryButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesView());
    }
}