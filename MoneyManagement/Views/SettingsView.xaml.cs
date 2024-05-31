
namespace MoneyManagement.Views;

public partial class SettingsView : ContentPage
{
	public SettingsView()
	{
		InitializeComponent();
	}

    public static implicit operator View(SettingsView v)
    {
        throw new NotImplementedException();
    }
}