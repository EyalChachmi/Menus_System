using System;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;
class Program
{
    public static void Main()
    {
        InterfaceMenu();
        DelegateMenu();
    }
    public static void InterfaceMenu()
    {
        Ex04.Menus.Interfaces.MainMenu mainMenu = new Ex04.Menus.Interfaces.MainMenu();
        Ex04.Menus.Interfaces.InnerMenu versionAndNumOfCapitalsMenu = new Ex04.Menus.Interfaces.InnerMenu("Version and Capitals");
        Ex04.Menus.Interfaces.InnerMenu dateAndTimeMenu = new Ex04.Menus.Interfaces.InnerMenu("Show Date/Time");
        Ex04.Menus.Interfaces.ShowCurrentDate showCurrentDate = new Ex04.Menus.Interfaces.ShowCurrentDate();
        Ex04.Menus.Interfaces.ShowCurrentTime showCurrentTime = new Ex04.Menus.Interfaces.ShowCurrentTime();
        Ex04.Menus.Interfaces.ShowCurrentVersion showCurrentVersion = new Ex04.Menus.Interfaces.ShowCurrentVersion();
        Ex04.Menus.Interfaces.ShowCurrentWordCapitalLetters showCurrentWordCapitalLetter = new Ex04.Menus.Interfaces.ShowCurrentWordCapitalLetters();

        versionAndNumOfCapitalsMenu.AddMenuChoice(showCurrentWordCapitalLetter);
        versionAndNumOfCapitalsMenu.AddMenuChoice(showCurrentVersion);
        dateAndTimeMenu.AddMenuChoice(showCurrentTime);
        dateAndTimeMenu.AddMenuChoice(showCurrentDate);
        mainMenu.AddInternalMenu(dateAndTimeMenu);
        mainMenu.AddInternalMenu(versionAndNumOfCapitalsMenu);
        mainMenu.ShowMainMenu();
    }
    public static void DelegateMenu()
    {
        Ex04.Menus.Delegates.MainMenu mainMenu = new Ex04.Menus.Delegates.MainMenu();
        Ex04.Menus.Delegates.InnerMenu versionAndNumOfCapitalsMenu = new Ex04.Menus.Delegates.InnerMenu("Version and Capitals");
        Ex04.Menus.Delegates.InnerMenu dateAndTimeMenu = new Ex04.Menus.Delegates.InnerMenu("Show Date/Time");
        Ex04.Menus.Delegates.ShowCurrentDate showCurrentDate = new Ex04.Menus.Delegates.ShowCurrentDate();
        Ex04.Menus.Delegates.ShowCurrentTime showCurrentTime = new Ex04.Menus.Delegates.ShowCurrentTime();
        Ex04.Menus.Delegates.ShowCurrentVersion showCurrentVersion = new Ex04.Menus.Delegates.ShowCurrentVersion();
        Ex04.Menus.Delegates.ShowCurrentWordCapitalLetters showCurrentWordCapitalLetter = new Ex04.Menus.Delegates.ShowCurrentWordCapitalLetters();

        versionAndNumOfCapitalsMenu.AddMenuChoice(showCurrentWordCapitalLetter);
        versionAndNumOfCapitalsMenu.AddMenuChoice(showCurrentVersion);
        dateAndTimeMenu.AddMenuChoice(showCurrentTime);
        dateAndTimeMenu.AddMenuChoice(showCurrentDate);
        mainMenu.AddInternalMenu(dateAndTimeMenu);
        mainMenu.AddInternalMenu(versionAndNumOfCapitalsMenu);
        mainMenu.ShowMainMenu();
    }
}
