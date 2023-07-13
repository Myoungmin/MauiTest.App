using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace MauiTest.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        int count = 0;

        public String CounterBtnText { get; set; }  

        public INavigation Navigation { get; set; }

        public ICommand CounterCommand { get; }
        public ICommand OpenDetailedPageCommand { get; }
        public ICommand OpenImagePageCommand { get; }

        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            CounterCommand = new Command(() => OnCounterClicked());
            OpenDetailedPageCommand = new Command(async () => await OnDetailsPageClickedAsync());
            OpenImagePageCommand = new Command(async () => await OnImagePageClickedAsync());
            CounterBtnText = "Click!";
        }

        private void OnCounterClicked()
        {
            count++;

            if (count == 1)
                CounterBtnText = $"Clicked {count} time";
            else
                CounterBtnText = $"Clicked {count} times";

            OnPropertyChanged(nameof(CounterBtnText));
        }

        private async Task OnDetailsPageClickedAsync()
        {
            await Navigation.PushAsync(new DetailsPage());
        }

        private async Task OnImagePageClickedAsync()
        {
            await Navigation.PushAsync(new ImagePage());
        }
    }
}
