namespace hoki;

public partial class ClubsPage : ContentPage
{
    public ClubsPage()
    {
        InitializeComponent();
    }

    private async void OnClubButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var clubName = button.CommandParameter as string;
        await Navigation.PushAsync(new ClubDetailPage(clubName));
    }
}
