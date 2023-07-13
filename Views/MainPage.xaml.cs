using MauiTest.ViewModels;

namespace MauiTest;

public partial class MainPage : ContentPage
{
	MainPageViewModel _viewModel;
	public MainPage()
	{
		InitializeComponent();
		_viewModel = new MainPageViewModel(Navigation);
		BindingContext= _viewModel;

	}	
}

