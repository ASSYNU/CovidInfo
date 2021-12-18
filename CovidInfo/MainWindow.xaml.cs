using System.Diagnostics;
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
            AddCountriesList();
            ShowCovidData("Poland");
            Tabs.BorderBrush = null;
        }

        private void Refresh(object sender, RoutedEventArgs routedEventArgs)
        {
            ShowCovidData("Poland");
        }

        private void ShowCovidData(string countryName)
        {
            Corona corona = new Corona();
            CovidSpecificInfo? receivedCoronaInfo = corona.getCoronaInfo(countryName);
            Trace.WriteLine("Loading Data...");
            
            if (receivedCoronaInfo.country != null)
            {
                cases.Text = receivedCoronaInfo.cases.ToString();
                todayCases.Text = receivedCoronaInfo.todayCases.ToString();
                deaths.Text = receivedCoronaInfo.deaths.ToString();
                todayDeaths.Text = receivedCoronaInfo.todayDeaths.ToString();
                recovered.Text = receivedCoronaInfo.recovered.ToString();
                todayRecovered.Text = receivedCoronaInfo.todayRecovered.ToString();
                casesPerOneMillion.Text = receivedCoronaInfo.casesPerOneMillion.ToString();
                deathsPerOneMillion.Text = receivedCoronaInfo.deathsPerOneMillion.ToString();
                tests.Text = receivedCoronaInfo.tests.ToString();
                testsPerOneMillion.Text = receivedCoronaInfo.testsPerOneMillion.ToString();
                oneCasePerPeople.Text = receivedCoronaInfo.oneCasePerPeople.ToString();
                oneDeathPerPeople.Text = receivedCoronaInfo.oneDeathPerPeople.ToString();
                oneTestPerPeople.Text = receivedCoronaInfo.oneTestPerPeople.ToString();
                recoveredPerOneMillion.Text = receivedCoronaInfo.recoveredPerOneMillion.ToString(CultureInfo.InvariantCulture);
                return;
            }

            MessageBox.Show("No Data For Selected Country");
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
