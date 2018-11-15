using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Globals
    {   
        public int Strenght { get; set; }
        public int HP { get; set; }
        public int Intel { get; set; }
        public List<Gear> Items = new List<Gear>();
        public Character Chara = new Character();
        public Globals()
        {
            Items.Add(new Gear { Name = "Coin", Value = 150 });
            Items.Add(new Gear { Name = "Steak", Value = 2 });
            Items.Add(new Gear { Name = "Flower", Value = 40 });
            Chara.Add_item("Coin", 111);
            Chara.Add_item("Steak", 144);
            /*Chara.Items.Add(new Gear {Name="Coin", Value=111 });
            Chara.Items.Add(new Gear { Name = "Steak", Value = 111 });*/
        }
    }
}
