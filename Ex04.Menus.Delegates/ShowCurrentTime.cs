using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ShowCurrentTime : MenuItem
    {
        private const string k_Title = "Show Time";

        public ShowCurrentTime() : base(k_Title)
        {
        }

        public override void SelectionAction(object i_sender)
        {
            MenuItemSelected += showCurrentTime_MenuItemSelected;
            OnMenuItemSelect(this);
            MenuItemSelected -= showCurrentTime_MenuItemSelected;
        }

        private void showCurrentTime_MenuItemSelected(object i_Sender)
        {
            Console.WriteLine(String.Format($"The current time is: {DateTime.Now.ToString("HH:mm:ss")}"));
            System.Threading.Thread.Sleep(500);
        }
    }
}
