using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace TerminalInfo.Models
{
    public class ViewTerminalWork
    {
        public string UserToken { get; set; }
        int _CommandId { get; set; }
        public AddCommand command = new AddCommand();
        ISession session { get; set; }
        public ViewTerminalWork(ISession session,int CommandId)
        {
            _CommandId = CommandId;
            UserToken = session.GetString("Token");
            
        }
        private string AllGetCommandsUrl= "http://178.57.218.210:198/commands/types?PageNumber={0}&token={1}";
        private string AddComandInTerminal= "http://178.57.218.210:198/terminals/{0}/commands?token={1}";



        private AllCommand AllCommand { get; set; }
        public  AllCommand AllCommandInfo(string Token){
            var url = string.Format(AllGetCommandsUrl, 1, Token);
           var result =  new CommandWork<AllCommand,object>().GetResultCommand(url,"Get",null);
            this.AllCommand = result;
            return result;

        }

        public Command InfoParams(string Token) =>
            AllCommand.items.FirstOrDefault(o => o.id == _CommandId);
       
        public ResultAddCommand AddComandTerminal(string Token,int IdTerminal, AddCommand command)
        {
            var url = string.Format(AddComandInTerminal, IdTerminal, Token);
            var result = new CommandWork<ResultAddCommand, AddCommand>().GetResultCommand(url,"POST", command);
            
            return result;
        }
    }
}
