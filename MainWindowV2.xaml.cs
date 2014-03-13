//Koodannut ja testannut toimivaksi 6.3.2014 Jenni Kallanto
using System;
using System.Collections.Generic;
using System.Data;
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
  public partial class MainWindowV2 : Window
  {
      private string YhteysMerkkijono;
      private string TaulunNimi;
      DataTable dt; //pysyy muistissa
      DataView dv;

    public MainWindowV2()
    {
        InitializeComponent();
        IniMyStuff();
    }

    private void IniMyStuff()
    {
        //esimerkki kuinka App.Configissa oleva connectionstring luetaan
        YhteysMerkkijono = JAMK.ICT.Properties.Settings.Default.Tietokanta;
        lbMessages.Content = YhteysMerkkijono;
        TaulunNimi = JAMK.ICT.Properties.Settings.Default.Taulu;
        try
        {
            string messu = "";
            dt = JAMK.ICT.Data.DBPlacebo.GetAllCustomersFromSQLServer(YhteysMerkkijono, TaulunNimi, out messu);
            dv = dt.DefaultView;
            //comboboxin täyttö
            dv.Sort = "city"; //kaupungit aakkosjärjestykseen
            DataTable dtCities = dv.ToTable("Cities", true, "city");
            cbCities.Items.Add("Näytä kaikki");
            foreach (DataRow dr in dtCities.Rows)
            {
                cbCities.Items.Add(dr[0]);
            }
            //kiinnitetään dataview datagridiin
            dgCustomers.ItemsSource = dv;
        }
        catch (Exception ex)
        {
            lbMessages.Content = ex.Message;
        }
    }

    private void btnGet3_Click(object sender, RoutedEventArgs e)
    {
        dgCustomers.ItemsSource = JAMK.ICT.Data.DBPlacebo.GetTestCustomers().DefaultView;
    }

    private void btnGetAll_Click(object sender, RoutedEventArgs e)
    {
        //sorttaus sukunimen mukaan
        dv.RowFilter = "";
        dv.Sort = "Lastname, Firstname";
        dgCustomers.ItemsSource = dv;
    }

    private void cbCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string kaupunki = cbCities.SelectedValue.ToString();
        if (kaupunki == "Näytä kaikki")
            dv.RowFilter = "";
        else
            dv.RowFilter = string.Format("city LIKE '{0}'", kaupunki);
    }

  }
}
