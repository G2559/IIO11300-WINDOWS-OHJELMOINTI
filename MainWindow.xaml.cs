//Koodannut ja testannut toimivaksi 6.3.2014 Jenni Kallanto
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
using JAMK.ICT.Data;

namespace H10ADOBlanco
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
      DataTable dt;
      string connector;
      string viesti;
      string city;

    public MainWindow()
    {
      InitializeComponent();
      IniMyStuff();
    }

    private void IniMyStuff()
    {
      //TODO täytetään combobox asiakkaitten maitten nimillä
      //esimerkki kuinka App.Configissa oleva connectionstring luetaan
      //lbMessages.Content = JAMK.ICT.Properties.Settings.Default.Tietokanta;

      connector = JAMK.ICT.Properties.Settings.Default.Tietokanta;

      dt = DBPlacebo.GetCitiesOfCustomersFromSQLServer(connector, "customer");

      DataView view = new DataView(dt);

      DataTable distinctValues = view.ToTable(true, "city");

      cbCountries.ItemsSource = distinctValues.DefaultView;

      cbCountries.DisplayMemberPath = distinctValues.Columns["city"].ToString();
      
    }

    private void btnGet3_Click(object sender, RoutedEventArgs e)
    {
        dt = DBPlacebo.GetTestCustomers();

        dgCustomers.DataContext = dt;

        //myös näin
        //dgCustomers.ItemsSource = DBPlacebo.GetTestCustomers().DefaultView;
    }

    private void btnGetAll_Click(object sender, RoutedEventArgs e)
    {
        viesti = "";

        dgCustomers.ItemsSource = DBPlacebo.GetAllCustomersFromSQLServer(connector, "customer", out viesti).DefaultView;

        lbMessages.Content = viesti;
        
    }

    private void btnGetFrom_Click(object sender, RoutedEventArgs e)
    {
        //KESKENKESKENKESKEN, muut toimii
        /*
        viesti = "";
      //TODO
        try
        {
            city = cbCountries.SelectedValue.ToString();

            dgCustomers.ItemsSource = DBPlacebo.GetAllCustomersFromSQLServerWhere(connector, "customer", out viesti, city).DefaultView;

            lbMessages.Content = viesti;
        }
        catch (Exception)
        {
            
            throw;
        }
        */
    }

  }
}
