using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ShowCurrentWordCapitalLetters : MenuItem
    {
        private const string k_Title = "Count Capitals";

        public ShowCurrentWordCapitalLetters() : base(k_Title)
        {
        }

        public override void SelectionAction(object i_sender)
        {
            MenuItemSelected += showCurrentWordCapitalLetters_MenuItemSelected;
            OnMenuItemSelect(this);
            MenuItemSelected -= showCurrentWordCapitalLetters_MenuItemSelected;
        }

        private void showCurrentWordCapitalLetters_MenuItemSelected(object i_Sender)
        {
            Console.WriteLine("Please enter your sentence");
            string userInput = Console.ReadLine();
            int countOfUpperLetters = 0;

            foreach (char c in userInput)
            {
                if (char.IsLetter(c) && char.IsUpper(c))
                {
                    countOfUpperLetters++;
                }
            }

            Console.WriteLine(string.Format($"There are {countOfUpperLetters} capitals in your sentence."));
        }
    }
}
