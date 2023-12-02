using System;
using Menus.Interfaces;

namespace Menus.Test
{
    internal class TestInterface
    {
        internal static void CreateInterfacesMenu(MainMenu i_MainMenu)
        {
            Interfaces.MenuItem showDateTime = new Interfaces.MenuItem("Show Date/Time", i_MainMenu);
            Interfaces.MenuItem versionAndCapitals = new Interfaces.MenuItem("Version and Capitals", i_MainMenu);
            i_MainMenu.AddSubMenu(showDateTime);
            i_MainMenu.AddSubMenu(versionAndCapitals);

            ShowDate showDateAction = new ShowDate();
            ShowTime showTimeAction = new ShowTime();
            Interfaces.MenuItem showDate = new Interfaces.MenuItem("Show Date", i_MainMenu, showDateAction);
            Interfaces.MenuItem showTime = new Interfaces.MenuItem("Show Time", i_MainMenu, showTimeAction);
            showDateTime.AddSubMenu(showDate);
            showDateTime.AddSubMenu(showTime);

            ShowVersion showVersionAction = new ShowVersion();
            ShowUpperNumber showUpperNumberAction = new ShowUpperNumber();
            Interfaces.MenuItem showVersion = new Interfaces.MenuItem("Show Version", i_MainMenu, showVersionAction);
            Interfaces.MenuItem showUpperNumber = new Interfaces.MenuItem("Count Capital", i_MainMenu, showUpperNumberAction);
            versionAndCapitals.AddSubMenu(showVersion);
            versionAndCapitals.AddSubMenu(showUpperNumber);
        }

        internal static void RunInterfacesMenu(MainMenu i_InterfacesMenu)
        {
            i_InterfacesMenu.Show();
        }

        internal class ShowDate : Menus.Interfaces.IDoActionWhenClicked
        {
            void Menus.Interfaces.IDoActionWhenClicked.DoAction()
            {
                Console.WriteLine(string.Format($"The Date is: {DateTime.Today:d}"));
            }
        }

        internal class ShowTime : Menus.Interfaces.IDoActionWhenClicked
        {
            void Menus.Interfaces.IDoActionWhenClicked.DoAction()
            {
                Console.WriteLine(string.Format($"The Hour is: {DateTime.Now:HH:mm:ss}"));
            }
        }

        internal class ShowVersion : Menus.Interfaces.IDoActionWhenClicked
        {
            void Menus.Interfaces.IDoActionWhenClicked.DoAction()
            {
                Console.WriteLine("Version: 23.3.4.9835");
            }
        }

        internal class ShowUpperNumber : Menus.Interfaces.IDoActionWhenClicked
        {
            void Menus.Interfaces.IDoActionWhenClicked.DoAction()
            {
                Console.WriteLine("Please enter your sentence");
                string inputString = Console.ReadLine();
                Console.WriteLine(string.Format($"There are {countUpper(inputString)} capitals in your sentence."));
            }
        }

        private static int countUpper(string i_StringInput)
        {
            int count = 0;

            for (int i = 0; i < i_StringInput.Length; i++)
            {
                if (char.IsUpper(i_StringInput[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}