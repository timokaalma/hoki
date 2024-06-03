namespace hoki;

public partial class ClubDetailPage : ContentPage
{
    public ClubDetailPage(string clubName)
    {
        InitializeComponent();
        ClubNameLabel.Text = clubName;
        ClubDetailsLabel.Text = GetClubDetails(clubName);
        ClubLogoImage.Source = GetClubLogoSource(clubName);
    }

    private string GetClubDetails(string clubName)
    {
        // Replace with actual club details
        if (clubName == "Tallinna HC Panter")
            return "Kodujäähall: Haabersti jäähall\r\nFacebook: https://www.facebook.com/hcpanter\r\nInstagram: https://www.instagram.com/hcpanter/\r\nKoduleht: www.hcpanter.ee\r\nPeatreener: Pelle Sildre\r\nTreener: Gennadi Korobov\r\nMeeskonna esindaja: Meelis Luht\r\nArst: Eva Mari Müts.";
        if (clubName == "Kohtla-Järve Viru Sputnik")
            return "Kodujäähall: Kohtla-Järve jäähall\r\nFacebook: https://www.facebook.com/ViruSputnik\r\nInstagram: https://www.instagram.com/virusputnik_hockey_team/\r\nKoduleht: http://virusputnik.ee/\r\nPeatreener: Anton Nekrassov\r\nTreener: Juri Urzumov\r\nMeeskonna esindaja: Sergei Konõšev\r\nArst: Alla Rae.";
        if (clubName == "Kohtla-Järve HC Everest")
            return "Kodujäähall: Kohtla-Järve jäähall\r\nFacebook: www.facebook.com/hceverest\r\nInstagram:  https://www.instagram.com/hc_everest/ \r\nKoduleht: www.hceverest.ee\r\nPeatreener: Alexander Smetanin  \r\nTreener: Andrei Heitkov\r\nMeeskonna esindaja: Anatoly Dubkov\r\nArst: Nikolai Usov\r\nTehnik: Timofei Salmin.";
        if (clubName == "Narva Paemurru Spordikool")
            return "Kodujäähall: Narva jäähall\r\nFacebook: www.facebook.com/PskNarva\r\nInstagram: https://www.instagram.com/narva.psk/\r\nKoduleht: www.npsk.ee\r\nPeatreener: Ilja Iljn\r\nAbitreener: Igor Ossipenkov\r\nMeeskonna esindaja: Leonid Gulov.";
        if (clubName == "Tartu Välk 494")
            return "Kodujäähall: Astri Arena\r\nFacebook: www.facebook.com/valk494\r\nInstagram:  https://www.instagram.com/valk494/ \r\nKoduleht: www.valk494.ee\r\nPeatreener:\r\nTreener: Oleg Puzanov\r\nTreener: Andrejs Maslovskis\r\nMeeskonna esindaja: Timo Lauri\r\nArst: Tanja Tiido\r\nTehnik: German Ruts.";
        return "Details not available.";
    }
    private ImageSource GetClubLogoSource(string clubName)
    {
        // Replace with actual image file paths or URIs
        if (clubName == "Tallinna HC Panter")
            return "pantrid.png";
        if (clubName == "Kohtla-Järve Viru Sputnik")
            return "virusputnik.png";
        if (clubName == "Kohtla-Järve HC Everest")
            return "everesthc.png";
        if (clubName == "Narva Paemurru Spordikool")
            return "narvapsk.jpg";
        if (clubName == "Tartu Välk 494")
            return "tartu.png";
        return "default_logo.png"; // Default image if no specific logo is found
    }
}
