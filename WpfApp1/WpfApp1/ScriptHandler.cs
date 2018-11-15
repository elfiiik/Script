using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace WpfApp1
{
    public class ScriptHandler
    {
        public Globals Global;
        public ScriptHandler()
        {

        }
        public ScriptHandler(Globals globals)
        {
            Global = globals;
        }

        public async void AddGear(Globals globals)
        {
            string script = File.ReadAllText(@"../../scripts/AddGear.txt");
            await CSharpScript.EvaluateAsync(script, globals: globals);
        }

        public async void StatUp(Globals globals)
        {
            string script = File.ReadAllText(@"../../scripts/StatsUp.txt");
            await CSharpScript.EvaluateAsync(script, globals: globals);
        }
    }
}
