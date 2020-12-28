using PhoneBookData;
using PhoneBookData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        private List<Entry> data = DataManager.GetData();
        public ActionResult Index()
        {
            data = data.OrderBy(e => e.Name.Split(' ')[1]).ToList();
            return View(data);
        }

    }
}