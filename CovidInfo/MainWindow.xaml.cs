using System.Globalization;
using System.Windows;
using CovidInfo.Core;

namespace CovidInfo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Corona corona = new Corona();
            CovidSpecificInfo? receivedCoronaInfo = corona.getCoronaInfo("Poland");
            if(receivedCoronaInfo != null) ShowCovidData(receivedCoronaInfo);
            AddCountriesList();
        }

        private void ShowCovidData(CovidSpecificInfo? data)
        {
            cases.Text = data.cases.ToString();
            todayCases.Text = data.todayCases.ToString();
            deaths.Text = data.deaths.ToString();
            todayDeaths.Text = data.todayDeaths.ToString();
            recovered.Text = data.recovered.ToString();
            todayRecovered.Text = data.todayRecovered.ToString();
            casesPerOneMillion.Text = data.casesPerOneMillion.ToString();
            deathsPerOneMillion.Text = data.deathsPerOneMillion.ToString();
            tests.Text = data.tests.ToString();
            testsPerOneMillion.Text = data.testsPerOneMillion.ToString();
            oneCasePerPeople.Text = data.oneCasePerPeople.ToString();
            oneDeathPerPeople.Text = data.oneDeathPerPeople.ToString();
            oneTestPerPeople.Text = data.oneTestPerPeople.ToString();
            recoveredPerOneMillion.Text = data.recoveredPerOneMillion.ToString(CultureInfo.InvariantCulture);
        }

        private void AddCountriesList()
        {
            countries countries = new countries();
            foreach (var country in countries.All())
            {
                // CountrySelectMenu.Items.Add(country);
            }
        }
    }
}
