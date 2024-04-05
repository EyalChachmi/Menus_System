using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class InnerMenu : MenuItem
    {
        private List<MenuItem> m_MenuChoices;

        public InnerMenu(string i_Title) : base(i_Title)
        {
            m_MenuChoices = new List<MenuItem>();
            //adding a null entry at index 0 to keep the "Exit" or "Back" option,
            m_MenuChoices.Add(null);// Placeholder for the 0 option, which is "Exit" or "Back".
        }

        private void checkIfUserChoiceIsValid(string i_UserChoice)
        {
            int userNumChoice;

            if (!int.TryParse(i_UserChoice, out userNumChoice))
            {
                throw new FormatException("Invalid choice. Please select a number");
            }

            // Adjusting the range check
            if (userNumChoice < 0 || userNumChoice >= m_MenuChoices.Count)
            {
                throw new Exception($"You need to select a number that is inside the correct range between 0 to {m_MenuChoices.Count - 1}");
            }
        }

        public void AddMenuChoice(MenuItem i_MenuChoice)
        {
            m_MenuChoices.Add(i_MenuChoice);
        }

        private void printCurrentMenu(string i_Title)
        {
            string currentExistOrBackOptionInMenu = Title == "Main Menu" ? "Exit" : "Back";

            Console.WriteLine(i_Title);
            for (int i = 1; i < m_MenuChoices.Count; i++)
            {
                Console.WriteLine(string.Format($"{i} -> {m_MenuChoices[i].Title}"));
            }

            Console.WriteLine(string.Format($"0 -> {currentExistOrBackOptionInMenu}"));
        }

        //the following function is recursive
        //The recursive calls continue until the user decides to exit the menu system by selecting 0
        //Each recursive call represents navigating deeper into nested menus until a base case is reached
        public void ShowInternalMenu(string i_Title)
        {
            bool continueMenu = true;
            string userInput;

            while (continueMenu)
            {
                printCurrentMenu(i_Title);// Display the current menu
                try
                {
                    Console.WriteLine(string.Format($"Please select a number that is inside the correct range between 0 to {m_MenuChoices.Count - 1}"));
                    userInput = Console.ReadLine();
                    checkIfUserChoiceIsValid(userInput);
                    int userInputNum = int.Parse(userInput);

                    Console.Clear();
                    if (userInputNum > 0)
                    {
                        MenuItem selectedMenuItem = m_MenuChoices[userInputNum];

                        if (selectedMenuItem is InnerMenu) // if the selected menu item is an internal menu, continue to show it in recursion
                        {
                            ((InnerMenu)selectedMenuItem).ShowInternalMenu(selectedMenuItem.Title);
                        }
                        else if (selectedMenuItem is IMenuItemAction) //if its base case, invoke it by its action
                        {
                            ((IMenuItemAction)selectedMenuItem).Invoke();
                            Console.WriteLine("Please type any key to continue");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        continueMenu = false;
                        Console.WriteLine(Title == "Main Menu" ? "Exiting...." : "Going back...");
                        System.Threading.Thread.Sleep(200);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }

                Console.Clear();
            }
        }
    }
}
