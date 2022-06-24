using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace TerminalInfo.Models
{
    public class Autorization
    {
        const string Login = "part";
        const string Password = "part";
        string urlToken = $"http://178.57.218.210:198/token?login={Login}&password={Password}";

        UserToken Token { get; set; }
        public string GetToken { get => Token.token; }

        public string GetResultCommand;
        public bool GetTokenSucses()
        {

            Token = new CommandWork<UserToken,object>().GetResultCommand(urlToken,"Get",null);

            if (this.Token.token != null)
            {
                return true;
            }
            return false;
        }

       
    }
}
