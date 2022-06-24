using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalInfo.Models
{
    public class ResultAddCommand
    {
        public Items item { get; set; }
        public bool success { get; set; }
    }

    public class Items
    {
        public int terminal_id { get; set; }
        public int command_id { get; set; }
        public int? parameter1 { get; set; }
        public int? parameter2 { get; set; }
        public int? parameter3 { get; set; }
        public int? parameter4 { get; set; }
        public string str_parameter1 { get; set; }
        public string str_parameter2 { get; set; }
        public int state { get; set; }
        public string state_name { get; set; }
        public string time_created { get; set; }
        public string time_delivered { get; set; }
        public int? id { get; set; }
    
    
  }
 
    
}
