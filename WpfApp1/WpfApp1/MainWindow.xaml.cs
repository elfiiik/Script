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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Globals globals = new Globals();
        public MainWindow()
        {
            InitializeComponent();
            globals.Strenght = 10;
            globals.HP = 100;
            globals.Intel = 200;
            List <Gear> items = globals.Items;
            ShowData();
        }

        public void ShowData()
        {
            stat1.Content = $"Strenght: {globals.Strenght}";
            stat2.Content = $"HP: {globals.HP}";
            stat3.Content = $"Intel: {globals.Intel}";
            invent.Content = "";
        }
    }
}
