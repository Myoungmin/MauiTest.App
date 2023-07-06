using MauiTest.ViewModels;

namespace MauiTest;

public partial class MainPage : ContentPage
{
	MainPageViewModel viewModel;
	public MainPage()
	{
		InitializeComponent();
		viewModel = new MainPageViewModel(Navigation);
		BindingContext= viewModel;
	}	
}

