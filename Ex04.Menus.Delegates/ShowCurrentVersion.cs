using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ShowCurrentVersion : MenuItem
    {
        private const string k_Title = "Show Version";
        private const string k_Version = "24.1.4.9633";

        public ShowCurrentVersion() : base(k_Title)
        {
        }

        public override void SelectionAction(object i_sender)
        {
            MenuItemSelected += showCurrentVersion_MenuItemSelected;
            OnMenuItemSelect(this);
            MenuItemSelected -= showCurrentVersion_MenuItemSelected;
        }

        private void showCurrentVersion_MenuItemSelected(object i_Sender)
        {
            Console.WriteLine(string.Format($"Version: {k_Version}"));
        }
    }
}