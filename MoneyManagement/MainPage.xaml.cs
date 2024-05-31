using MoneyManagement.Views;
using Microsoft.Maui.Controls;

namespace MoneyManagement
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadHomePage();
        }

        private async void LoadHomePage()
        {
            // Load the HomeView when the MainPage is initialized
            await Navigation.PushAsync(new HomeView());
        }

        private async void HomeButton_Clicked(object sender, EventArgs e)
        {
            // Load the HomeView when the Home button is clicked
            await Navigation.PushAsync(new HomeView());
        }

        private async void TransactionsButton_Clicked(object sender, EventArgs e)
        {
            // Load the TransactionsView when the Transactions button is clicked
            await Navigation.PushAsync(new TransactionsView());
        }

        private async void CategoriesButton_Clicked(object sender, EventArgs e)
        {
            // Load the CategoriesView when the Categories button is clicked
            await Navigation.PushAsync(new CategoriesView());
        }

        private async void BudgetButton_Clicked(object sender, EventArgs e)
        {
            // Load the BudgetView when the Budget button is clicked
            await Navigation.PushAsync(new BudgetView());
        }

        private async void SettingsButton_Clicked(object sender, EventArgs e)
        {
            // Load the SettingsView when the Settings button is clicked
            await Navigation.PushAsync(new SettingsView());
        }
    }
}