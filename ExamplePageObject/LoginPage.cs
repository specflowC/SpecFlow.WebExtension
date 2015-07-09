﻿using OpenQA.Selenium;

namespace SpecFlow.WebExtension
{
    public class LoginPage
    {
        public ByEx Username { get { return new ByEx(By.Id("Username")); } }

        public ByEx Password { get { return new ByEx(By.Id("Password")); } }

        public ByEx LogInButton { get { return new ByEx(By.TagName("input"), "value", "Log in"); } }
    }
}
