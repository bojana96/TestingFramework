﻿using System;
using System.Collections.Generic;
using System.Text;
using BaseSetup.Page;
using OpenQA.Selenium;

namespace BaseSetup.Browser
{
    public static class BrowserExtensionMethods
    {
        public static T GoToPage<T>(this IWebDriver driver) where T : BasePage, new()
        {
            var page = new T { Driver = driver };

            page.Driver.Navigate().GoToUrl(page.Url);

            return page;
        }
    }
}
