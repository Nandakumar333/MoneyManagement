namespace MoneyManagement.Views;

public partial class AddIncomePage : ContentPage
{
	public AddIncomePage()
	{
		InitializeComponent();
	}
    private void OnAddIncomeClicked(object sender, EventArgs e)
    {
        // Validate input fields
        if (string.IsNullOrWhiteSpace(IncomeAmountEntry.Text))
        {
            DisplayAlert("Error", "Please enter the amount.", "OK");
            return;
        }

        // Convert amount to decimal
        if (!decimal.TryParse(IncomeAmountEntry.Text, out decimal amount))
        {
            DisplayAlert("Error", "Invalid amount format.", "OK");
            return;
        }

        // Get selected category
        string category = IncomeCategoryPicker.SelectedItem as string;
        if (string.IsNullOrWhiteSpace(category))
        {
            DisplayAlert("Error", "Please select a category.", "OK");
            return;
        }

        // Get selected date
        DateTime date = IncomeDatePicker.Date;

        // Get notes
        string notes = IncomeNotesEditor.Text;

        // Perform the logic to add income (e.g., save to database, update balance, etc.)
        // You would implement this according to your app's architecture

        // Display success message
        DisplayAlert("Success", "Income added successfully.", "OK");

        // Navigate back to the previous page or perform any other navigation as needed
        Navigation.PopAsync();
    }
    private async void AddEditCategoryButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesView());
    }
}