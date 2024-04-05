using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowCurrentVersion : MenuItem, IMenuItemAction
    {
        private const string k_Version = "24.1.4.9633";
        private const string k_Title = "Show Version";

        public ShowCurrentVersion() : base(k_Title)
        {
        }

        void IMenuItemAction.Invoke()
        {
            Console.WriteLine(string.Format($"Version: {k_Version}"));
        }
    }
}
