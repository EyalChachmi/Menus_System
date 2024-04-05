using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowCurrentDate : MenuItem, IMenuItemAction
    {
        private const string k_Title = "Show Date";

        public ShowCurrentDate() : base(k_Title)
        {
        }

        void IMenuItemAction.Invoke()
        {
            Console.WriteLine(String.Format("The current date right now is: {0}.{1}.{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
        }
    }
}
