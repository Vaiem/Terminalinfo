using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalInfo.Models
{
    public interface ICommandWork <T,U> where T : class where U : class
    {
         T GetResultCommand(string request,string requstMethod, U PostOrPutRequest);


    }
}
