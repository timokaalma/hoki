namespace hoki
{
    public partial class ChampionsPage : ContentPage
    {
        public ChampionsPage()
        {
            InitializeComponent();

            var champions = new List<HockeyChampion>
            {
                new HockeyChampion { Year = "2022/2023", ChampionName = "Tallinna HC Panter (Coolbet Hokiliiga võitis Riia HK Kurbads)" },
                new HockeyChampion { Year = "2021/2022", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "2020/2021", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "2019/2020", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "2018/2019", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "2017/2018", ChampionName = "Tallinna HC Viking" },
                new HockeyChampion { Year = "2016/2017", ChampionName = "Narva PSK" },
                new HockeyChampion { Year = "2015/2016", ChampionName = "Narva PSK" },
                new HockeyChampion { Year = "2014/2015", ChampionName = "Tartu Kalev-Välk" },
                new HockeyChampion { Year = "2013/2014", ChampionName = "Tallinna HK Viiking Sport" },
                new HockeyChampion { Year = "2012/2013", ChampionName = "Tallinna HK Viiking Sport" },
                new HockeyChampion { Year = "2011/2012", ChampionName = "Tartu Kalev-Välk" },
                new HockeyChampion { Year = "2010/2011", ChampionName = "Tartu Kalev-Välk" },
                new HockeyChampion { Year = "2009/2010", ChampionName = "Kohtla-Järve Viru Sputnik" },
                new HockeyChampion { Year = "2008/2009", ChampionName = "Tallinna HK Stars" },
                new HockeyChampion { Year = "2007/2008", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "2006/2007", ChampionName = "Tallinna HK Stars" },
                new HockeyChampion { Year = "2005/2006", ChampionName = "Tallinna HK Stars" },
                new HockeyChampion { Year = "2004/2005", ChampionName = "Tallinna HK Stars" },
                new HockeyChampion { Year = "2003/2004", ChampionName = "Tallinna HC Panter" },
                new HockeyChampion { Year = "2002/2003", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "2001/2002", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "2000/2001", ChampionName = "Narva 2000" },
                new HockeyChampion { Year = "1999/2000", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "1998/1999", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "1997/1998", ChampionName = "Narva Kreenholm" },
                new HockeyChampion { Year = "1996/1997", ChampionName = "Tartu Välk 494" },
                new HockeyChampion { Year = "1995/1996", ChampionName = "Narva Kreenholm" },
                new HockeyChampion { Year = "1994/1995", ChampionName = "Narva Kreenholm" },
                new HockeyChampion { Year = "1993/1994", ChampionName = "Narva Kreenholm" },
                new HockeyChampion { Year = "1992/1993", ChampionName = "Narva Kreenholm" },
                new HockeyChampion { Year = "1991/1992", ChampionName = "Narva Kreenholm" },
            };

            ChampionsListView.ItemsSource = champions;
        }
    }

    public class HockeyChampion
    {
        public string Year { get; set; }
        public string ChampionName { get; set; }
    }
}
