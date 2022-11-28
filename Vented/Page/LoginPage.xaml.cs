using Vented.ViewModel;

namespace Vented.Page;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; 
	}
}