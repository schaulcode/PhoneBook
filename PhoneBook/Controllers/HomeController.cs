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
        private List<Entry> data = App_Start.Startup.data;
        public ActionResult Index()
        {
            data = data.OrderBy(e => e.Name.Split(' ')[1]).ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Index(string delete)
        {
            data.Remove(data.Find(e => e.Name == delete));
            data = data.OrderBy(e => e.Name.Split(' ')[1]).ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult Index(string SearchField, Entry editEntry, string updateEntry)
        {
            if (SearchField != null)
            {
                data = data.FindAll(e => e.Name.StartsWith(SearchField) || e.Name.Split(' ')[1].StartsWith(SearchField));
                data = data.OrderBy(e => e.Name.Split(' ')[1]).ToList();
                return View(data);
            }
            else
            {
                if (updateEntry != string.Empty)
                {
                    data[data.FindIndex(e => e.Name == updateEntry)] = editEntry;
                    data = data.OrderBy(e => e.Name.Split(' ')[1]).ToList();
                    return View(data);
                }
                else
                {
                    data.Add(editEntry);
                    data = data.OrderBy(e => e.Name.Split(' ')[1]).ToList();
                    return View(data);

                }
                
            }

            
        }
       

    }
}