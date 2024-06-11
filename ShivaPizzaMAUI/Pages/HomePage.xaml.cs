namespace ShivaPizzaMAUI.Pages;

public partial class HomePage : ContentPage
{
	private readonly HomeView _homeView;
	public HomePage(HomeView homeView)
	{
		InitializeComponent();
		_homeView = homeView;
		BindingContext = _homeView;
	}
}