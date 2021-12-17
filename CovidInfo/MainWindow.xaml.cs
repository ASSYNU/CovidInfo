using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CovidInfo.Core;

namespace CovidInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
            // country.Text = data.country.ToString();
            cases.Text = data?.cases.ToString();
            todayCases.Text = data?.todayCases.ToString();
            deaths.Text = data?.deaths.ToString();
            todayDeaths.Text = data?.todayDeaths.ToString();
            recovered.Text = data?.recovered.ToString();
            todayRecovered.Text = data?.todayRecovered.ToString();
            casesPerOneMillion.Text = data?.casesPerOneMillion.ToString();
            deathsPerOneMillion.Text = data?.deathsPerOneMillion.ToString();
            tests.Text = data?.tests.ToString();
            testsPerOneMillion.Text = data?.testsPerOneMillion.ToString();
            oneCasePerPeople.Text = data?.oneCasePerPeople.ToString();
            oneDeathPerPeople.Text = data?.oneDeathPerPeople.ToString();
            oneTestPerPeople.Text = data?.oneTestPerPeople.ToString();
            recoveredPerOneMillion.Text = data?.recoveredPerOneMillion.ToString(CultureInfo.InvariantCulture);
        }

        private void AddCountriesList()
        {
            CountrySelectMenu.Items.Add("Poland");
        }
    }
}
