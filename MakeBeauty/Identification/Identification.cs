using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeBeauty.Identification
{
    using System.Web.Mvc;

    public static class Identification
    {
        public static bool Identify(ViewDataDictionary data)
        {
            return true;// data.ContainsKey("AccessLevel") && data["AccessLevel"].Equals("Admin");
        }
    }
}