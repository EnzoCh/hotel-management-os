﻿using System.Web;
using System.Web.Mvc;

namespace hotel_management_os
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
