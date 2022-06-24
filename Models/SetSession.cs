using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TerminalInfo.Models
{
    public static class SetSession
    {
        private static Dictionary<int,ResultAddCommand> historyCommand = new Dictionary<int,ResultAddCommand>();
        public static Dictionary<int, ResultAddCommand> GetHistoryComand(this ISession session)
        {
            var resultString = session.GetString("HistoryComand");
            if (resultString != null)
            {
                var Result = JsonConvert.DeserializeObject<Dictionary<int,ResultAddCommand>>(resultString);
                if (Result.Count() != 0)
                {
                    return Result;

                }

            }
            
            return historyCommand;
            
        }

        public static void AddHistoryCommand(this ISession session, ResultAddCommand resultAddCommand)
        {
            if (historyCommand.Count() == 0)
            {
                historyCommand[1] = resultAddCommand;
                var result = JsonConvert.SerializeObject(historyCommand);
                session.SetString("HistoryComand", result);
                
            }
            else
            {
                int id = historyCommand.Count();
                while (historyCommand.ContainsKey(id))
                {
                    id++;
                }
                
                historyCommand[id] = resultAddCommand;
                var result = JsonConvert.SerializeObject(historyCommand);
                session.SetString("HistoryComand", result);
            }

            
        }
    }
}
