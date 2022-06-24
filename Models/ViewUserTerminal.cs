using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalInfo.Models
{
    public class ViewUserTerminal
    {
        public Command[] ViewCommands { get; set; }
        public Command InfoParams { get; set; }
        public AddCommand command { get; set; }
        public int IdTerminal { get; set; }
        public Dictionary<int,ResultAddCommand> HistoryCommand = new Dictionary<int, ResultAddCommand>();
        public string GetNameCommand(int id) => ViewCommands.FirstOrDefault(o => o.id == id).name;
    }
}
