﻿using System.Web;
using System.Web.Mvc;

namespace Create_PowerPoint_presentation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
