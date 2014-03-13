using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity; //tarvitaan Load-metodille
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
  public partial class MainWindowV3EF : Window
  {
      private string YhteysMerkkijono;
      private string TaulunNimi;
      DataTable dt; //pysyy muistissa
      DataView dv;

    public MainWindowV3EF()
    {
        InitializeComponent();
        IniMyStuff();
    }

    private void IniMyStuff()
    {

    }


    private void btnGetAll_Click(object sender, RoutedEventArgs e)
    {
        DemoxOyEntities2 db = new DemoxOyEntities2();
        db.asiakkaat.Load();
        dgCustomers.DataContext = db.asiakkaat.Local;
    }

    private void cbCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

  }
}
