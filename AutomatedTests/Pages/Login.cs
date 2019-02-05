using System;
using NUnit.Framework;

namespace MaximusFramework
{
    public class Login
    {
        public bool IsAt()
        {
            return Start.GetTitle.Contains("Administator Login");
        }

        public void GoToPage()
        {
            FindBy.ClassAndClick("login");
        }
        
        public void SendYourEmail()
        {
            Start.GetDriver.SwitchTo().Window(Start.GetDriver.WindowHandles[1]);
            FindBy.NameAndSendKeys("username", "testertomson@gmail.com");
        }

        public void SendYourPassword()
        {
            Start.GetDriver.SwitchTo().Window(Start.GetDriver.WindowHandles[1]);
            FindBy.NameAndSendKeys("password", "Qwerty!23");
        }

        public void Submit()
        {
            Start.GetDriver.SwitchTo().Window(Start.GetDriver.WindowHandles[1]);
            FindBy.IdAndClick("login");    
        }
    }
}