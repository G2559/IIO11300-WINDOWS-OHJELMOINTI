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
using JAMK.ICT;

namespace H10ADOBlanco
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindowV4 : Window
  {
      //Versio 4 Strongly Typed DataSet
      //Typed DataSet luodaan Wisardilla
      Viini ds;
      JAMK.ICT.ViiniTableAdapters.customersTableAdapter ta;
      DataView dv;
    public MainWindowV4()
    {
        InitializeComponent();
        IniMyStuff();
    }

    private void IniMyStuff()
    {
        ds = new Viini();
        ta = new JAMK.ICT.ViiniTableAdapters.customersTableAdapter();
        ta.Fill(ds.customers);
        dv = ds.customers.DefaultView;
        dgCustomers.DataContext = dv;
        //täytetään combobox kaupunkien nimillä ja nyt nimet saadaan LINQ kyselyllä
        var kaupungit = (from k in ds.customers
                         where k.City != null 
                         select k.City).Distinct();
        cbCities.Items.Add("Näytä kaikki");
        foreach (var k in kaupungit)
        {
            cbCities.Items.Add(k);
        }
    }

    private void cbCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //filteroidaan dataviewtä valinnan mukaisesti
        string kaupunki = cbCities.SelectedValue.ToString();
        if (kaupunki == "Näytä kaikki")
        {
            dv.RowFilter = "";
        }
        else
        {
            dv.RowFilter = string.Format("city LIKE '{0}'", kaupunki);
        }

    }

    private void btnGetData_Click(object sender, RoutedEventArgs e)
    {
        //haetaan tietokannasta uudestaan tiedot datasettiimme
        ta.Fill(ds.customers);
        dv = ds.customers.DefaultView;
    }

    private void btnSaveData_Click(object sender, RoutedEventArgs e)
    {
        //tallentaa muutokset muistissa olevasta DataTablesta tietokantaan
        try
        {
            ta.Update(ds.customers);
            ta.Fill(ds.customers);
            dv = ds.customers.DefaultView;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

  }
}
