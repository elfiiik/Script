using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Globals globals = new Globals();
        public ScriptHandler scripts = new ScriptHandler();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            ShowData();
        }

        public void LoadData()
        {
            globals.Strenght = 10;
            globals.HP = 100;
            globals.Intel = 200;
            List<Gear> items = globals.Items;
        }

        public void ShowData()
        {
            invent.Items.Clear();
            stat1.Content = $"Strenght: {globals.Chara.Strenght}";
            stat2.Content = $"HP: {globals.Chara.HP}";
            stat3.Content = $"Intel: {globals.Chara.Intel}";
            foreach (Gear item in globals.Chara.Items)
            {
                invent.Items.Add($"{item.Name} ... {item.Value}");
            }
        }

        private void Load_Script_1(object sender, RoutedEventArgs e)
        {
            scripts.AddGear(globals);
            ShowData();
        }

        private void Load_Script_2(object sender, RoutedEventArgs e)
        {
            scripts.StatUp(globals);
            ShowData();
        }
    }
}
