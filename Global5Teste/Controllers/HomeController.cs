using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Global5Teste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var servers = new List<Server>();

            servers.Add(new Server { Id = 1, Name = "AA", HostName = "", Password = "", Porta = "", St = true , Usuario="Debss"});
            servers.Add(new Server { Id = 2, Name = "BB", HostName = "", Password = "", Porta = "", St = true, Usuario = "Debss" });
            servers.Add(new Server { Id = 3, Name = "CC", HostName = "", Password = "", Porta = "", St = true, Usuario = "Debss" });
            servers.Add(new Server { Id = 3, Name = "dd", HostName = "", Password = "", Porta = "", St = true, Usuario = "Debss" });

            ViewData["Company"] = servers;
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<Server> AddServer(Server model)
        {
            var servers = new List<Server>();

            servers.Add(model);

            ViewData["Company"] = servers;

            return servers;
        }


        public List<Server> DeleteServer(ActionModel model)
        {
            var servers = new List<Server>();

            servers.Add(new Server { Id = 1, Name = "AA", HostName = "", Password = "", Porta = "", St = true, Usuario = "Debss" });
            servers.Add(new Server { Id = 2, Name = "BB", HostName = "", Password = "", Porta = "", St = true, Usuario = "Debss" });
            servers.Add(new Server { Id = 3, Name = "CC", HostName = "", Password = "", Porta = "", St = true, Usuario = "Debss" });
            servers.Add(new Server { Id = 3, Name = "dd", HostName = "", Password = "", Porta = "", St = true, Usuario = "Debss" });

            var serverExcluded = servers.Where(x => x.Id == model.Id).FirstOrDefault();

            servers.Remove(serverExcluded);
            
            ViewData["Company"] = servers;

            return servers;
        }
    }

    public class Server
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Name { get; set; }
        public string HostName { get; set; }
        public string Porta { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool St { get; set; }
    }
    public class ActionModel {
        public int Id { get; set; }
    }
}