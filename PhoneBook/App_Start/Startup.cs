using PhoneBookData;
using PhoneBookData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.App_Start
{
    public static class Startup
    {
        public static List<Entry> data = DataManager.GetData();
    }
}