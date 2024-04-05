using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowCurrentTime : MenuItem, IMenuItemAction
    {
        private const string k_Title = "Show Time";

        public ShowCurrentTime() : base(k_Title)
        {
        }

        void IMenuItemAction.Invoke()
        {
            Console.WriteLine(String.Format($"The current time is: {DateTime.Now.ToString("HH:mm:ss")}"));
        }
    }
}
