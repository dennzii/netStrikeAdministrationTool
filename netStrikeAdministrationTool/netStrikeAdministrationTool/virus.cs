using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netStrikeAdministrationTool
{
   public class client
    {
        public string Nick { get; }
       public  bool isVirus;

       public client(string nick)
        {
            Nick = nick;
        }

    }
}
