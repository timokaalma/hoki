using hoki;
using Microsoft.Maui.Controls;

namespace HokiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClubsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClubsPage());
        }

        private async void OnArenasButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArenasPage());
        }

        private async void OnLeagueHistoryButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LeagueHistoryPage());
        }
    }
}
