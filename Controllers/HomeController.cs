using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TerminalInfo.Models;
using Microsoft.Extensions.DependencyInjection;

namespace TerminalInfo.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            var getToken = new Autorization();
            if (getToken.GetTokenSucses())
            {
                
                HttpContext.Session.SetString("Token", getToken.GetToken);
                return RedirectToAction(nameof(Terminal));
            }
            
            return View();
        }

        [HttpGet]
        public IActionResult Terminal(int id = 0)
        {
            var Token = HttpContext.Session.GetString("Token");
            
             var result =  new ViewTerminalWork(HttpContext.Session, id);
            ViewBag.Increment = 1;
            return View(new ViewUserTerminal {
                command = result.command,
                ViewCommands = result.AllCommandInfo(Token).items,
                InfoParams = result.InfoParams(Token),
                HistoryCommand = HttpContext.Session.GetHistoryComand()
            });
        }

        
        [HttpPost]
        public IActionResult Add(ViewUserTerminal addCommand)
        {
            var Token = HttpContext.Session.GetString("Token");
        
            var ResultAddComand = new ViewTerminalWork(HttpContext.Session, 0)
            .AddComandTerminal(Token, addCommand.IdTerminal, addCommand.command);
            if (ResultAddComand != null)
            {
                HttpContext.Session.AddHistoryCommand(ResultAddComand);
                return RedirectToAction("Terminal");
            }
            return View("Error");
        }

        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }

    }
}