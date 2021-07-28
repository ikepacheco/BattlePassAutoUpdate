using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePassPanelAutomatico.secure
{
    class variables
    {
        private static string _server = @"DESKTOP-V06RR33\DEMONFAS";
        private static string _database = "GunzDB";

        public static string server
        {
            get
            {
                return _server;
            }
        }
        public static string database
        {
            get
            {
                return _database;
            }
        }
    }
}
