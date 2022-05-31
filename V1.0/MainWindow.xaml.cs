using System;
using System.Collections.Generic;
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
using UniversalServer.ViewModels;

namespace UniversalServer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        //Model.DBAccess _dbAccess;
        //Model.ServerMockUp _serv;



        //Model.TempValue t;
        //Model.HumidValue h;
        //Model.PressureValue p;
        //DateTime dt;
        //string ipa;

        //public MainWindow()
        //{
        //    InitializeComponent();
        //    this.DataContext = new MainViewModel();

        //}

        //private void btnConDB(object sender, RoutedEventArgs e)
        //{
        //    //aufrufen constructor
        //    _dbAccess = new Model.DBAccess();
        //    _dbAccess.DBStart();
        //}

        //private void btnSendData(object sender, RoutedEventArgs e)
        //{
        //    _serv = new Model.ServerMockUp();
        //    _serv.Start();
        //    string dumm;
        //    //dumm = _serv.GetParameter();
        //    _dbAccess.Show(t, h, p, dt, ipa);
        //    //_dbAccess.InsertData();
        //}
    }
}
