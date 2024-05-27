namespace hoki;

public partial class ClubDetailPage : ContentPage
{
    public ClubDetailPage(string clubName)
    {
        InitializeComponent();
        ClubNameLabel.Text = clubName;
        ClubDetailsLabel.Text = GetClubDetails(clubName);
    }

    private string GetClubDetails(string clubName)
    {
        // Replace with actual club details
        if (clubName == "Club1")
            return "Details about Club 1.";
        if (clubName == "Club2")
            return "Details about Club 2.";
        return "Details not available.";
    }
}
