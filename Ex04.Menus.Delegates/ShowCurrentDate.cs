using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ShowCurrentDate : MenuItem
    {
        private const string k_Title = "Show Date";

        public ShowCurrentDate() : base(k_Title)
        {
        }

        public override void SelectionAction(object i_sender)
        {
            MenuItemSelected += showCurrentDate_MenuItemSelected;
            OnMenuItemSelect(this);
            MenuItemSelected -= showCurrentDate_MenuItemSelected;
        }

        private void showCurrentDate_MenuItemSelected(object i_Sender)
        {
            Console.WriteLine(String.Format("The current date right now is: {0}.{1}.{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
        }
    }
}
