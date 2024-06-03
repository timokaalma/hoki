namespace hoki;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnHistoryButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HistoryPage());
    }

    private async void OnClubsButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClubsPage());
    }
    private async void OnChampionsButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChampionsPage());
    }

}
