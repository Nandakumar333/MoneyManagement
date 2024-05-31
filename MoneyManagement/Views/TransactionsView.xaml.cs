
namespace MoneyManagement.Views;

public partial class TransactionsView : ContentPage
{
	public TransactionsView()
	{
		InitializeComponent();
	}

    public static implicit operator View(TransactionsView v)
    {
        throw new NotImplementedException();
    }
}