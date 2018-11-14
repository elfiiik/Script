using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Script_AddGear : ScriptInterface
    {
        public string Jmeno;
        public int Hodnota;
        public void LoadVars(string jmeno, int hodnota)
        {
            Jmeno = jmeno;
            Hodnota = hodnota;
        }
    }
}
