using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class InnerMenu : MenuItem
    {
        private List<MenuItem> m_MenuChoices;

        public InnerMenu(string i_Title) : base(i_Title)
        {
            m_MenuChoices = new List<MenuItem>();
            //adding a null entry at index 0 to keep the "Exit" or "Back" option,
            m_MenuChoices.Add(null); // Placeholder for the 0 option, which is "Exit" or "Back".
        }

        private void checkIfUserChoiceIsValid(string i_UserChoice)
        {
            if (!int.TryParse(i_UserChoice, out int userNumChoice))
            {
                throw new FormatException("Invalid choice. Please select a number.");
            }

            // Adjusting the range check
            if (userNumChoice < 0 || userNumChoice >= m_MenuChoices.Count)
            {
                throw new Exception($"You need to Select a number that is inside the correct range between 0 to {m_MenuChoices.Count - 1}");
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

        public override void SelectionAction(object i_Sender)
        {
            MenuItemSelected += InnerMenu_MenuItemSelected;
            OnMenuItemSelect(this);
            MenuItemSelected -= InnerMenu_MenuItemSelected;
        }

        //the following function is recursive
        //The recursive calls continue until the user decides to exit the menu system by selecting 0
        //Each recursive call represents navigating deeper into nested menus until a base case is reached
        public void InnerMenu_MenuItemSelected(object i_Sender)
        {
            string currTitle = Title; // Simplified access to the current menu's title.
            bool continueMenu = true;
            string userInput;
            int userInputNum;

            while (continueMenu)
            {
                printCurrentMenu(currTitle); // Display the current menu
                try
                {
                    Console.WriteLine(string.Format($"Please Select a number that is inside the correct range between 0 to {m_MenuChoices.Count - 1}"));
                    userInput = Console.ReadLine();
                    checkIfUserChoiceIsValid(userInput);
                    userInputNum = int.Parse(userInput);
                    Console.Clear();
                    if (userInputNum == 0)
                    {
                        continueMenu = false;
                        // If the user chooses 0, exit the current menu or go back to the previous menu
                        Console.WriteLine(Title == "Main Menu" ? "Exiting...." : "Going back...");
                        System.Threading.Thread.Sleep(500);
                    }
                    else if (m_MenuChoices[userInputNum] is MenuItem menuItem)
                    {
                        menuItem.SelectionAction(menuItem);
                        if (!(menuItem is InnerMenu))
                        {
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
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
