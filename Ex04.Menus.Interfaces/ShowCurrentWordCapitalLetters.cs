using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowCurrentWordCapitalLetters : MenuItem, IMenuItemAction
    {
        private const string k_Title = "Count Capitals";

        public ShowCurrentWordCapitalLetters() : base(k_Title)
        {
        }

        void IMenuItemAction.Invoke()
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
