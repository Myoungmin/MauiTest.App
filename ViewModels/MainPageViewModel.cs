using System.Windows.Input;

namespace MauiTest.ViewModels
{
    public class MainPageViewModel
    {
        int count = 0;

        public String CounterBtnText { get; set; }  

        public INavigation Navigation { get; set; }

        public ICommand CounterCommand { get; }
        public ICommand OpenDetailedPageCommand { get; }

        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            CounterCommand = new Command(() => OnCounterClicked());
            OpenDetailedPageCommand = new Command(async () => await OnDetailsPageClickedAsync());
        }

        private void OnCounterClicked()
        {
            count++;

            if (count == 1)
                CounterBtnText = $"Clicked {count} time";
            else
                CounterBtnText = $"Clicked {count} times";
        }

        private async Task OnDetailsPageClickedAsync()
        {
            await Navigation.PushAsync(new DetailsPage());
        }
    }
}
