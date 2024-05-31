namespace MoneyManagement.Views;

public partial class CategoriesView : ContentPage
{
    public CategoriesView()
    {
        InitializeComponent();
        LoadCategories(); // Load categories when the page is initialized
    }

    private void LoadCategories()
    {
        // Dummy implementation - You would replace this with your actual logic to load categories
        // For demonstration purposes, let's assume we have some dummy categories
        var categories = GetDummyCategories();

        // Clear any existing views from the container
        CategoriesContainer.Children.Clear();

        // Add categories dynamically
        foreach (var category in categories)
        {
            var label = new Label
            {
                Text = category,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                Margin = new Thickness(0, 5, 0, 0)
            };

            CategoriesContainer.Children.Add(label);
        }
    }

    // Dummy method to get some categories
    private List<string> GetDummyCategories()
    {
        return new List<string>
            {
                "Food",
                "Transportation",
                "Utilities"
                // Add more categories as needed
            };
    }

    private async void AddCategoryButton_Clicked(object sender, EventArgs e)
    {
        // Logic to navigate to the page where user can add a new category
        //await Navigation.PushAsync(new AddCategoryPage());
    }

}