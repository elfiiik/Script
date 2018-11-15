using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class Character
    {
        public List<Gear> Items = new List<Gear>();
        public double Strenght = 100;
        public double HP = 100;
        public double Intel = 200;
        public Character()
        {

        }

        public void Add_item(string name, int value)
        {
            Items.Add(new Gear { Name = name, Value = value });
        }

        public void StatUp(double value)
        {
            Strenght = Strenght * value;
            HP = HP * value;
            Intel = Intel * value;
        }
    }
}
