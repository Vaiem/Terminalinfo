using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalInfo.Models
{
    public class AllCommand
    {
       public int? page_number { get; set; }
       public int? items_per_page { get; set; }
       public int? items_count { get; set; }
       public Command[] items { get; set; }
       public bool success { get; set; }
    }
}
