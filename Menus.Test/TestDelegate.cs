using System;

namespace Menus.Test
{
    public class TestDelegate
    {
        internal static void CreateDelegatesMenu(Delegates.MainMenu i_MainMenu)
        {
            Delegates.MenuItem showDateTime = new Delegates.MenuItem("Show Date/Time", i_MainMenu);
            Delegates.MenuItem versionAndCapitals = new Delegates.MenuItem("Version and Capitals", i_MainMenu);
            i_MainMenu.AddSubMenu(showDateTime);
            i_MainMenu.AddSubMenu(versionAndCapitals);

            Delegates.MenuItem showDate = new Delegates.MenuItem("Show Date", i_MainMenu);
            showDate.Action += ShowDateAction;
            Delegates.MenuItem showTime = new Delegates.MenuItem("Show Time", i_MainMenu);
            showTime.Action += ShowTimeAction;
            showDateTime.AddSubMenu(showDate);
            showDateTime.AddSubMenu(showTime);

            Delegates.MenuItem showVersion = new Delegates.MenuItem("Show Version", i_MainMenu);
            showVersion.Action += ShowVersionAction;
            Delegates.MenuItem showUpperNumber = new Delegates.MenuItem("Count Capital", i_MainMenu);
            showUpperNumber.Action += ShowUpperNumberAction;
            versionAndCapitals.AddSubMenu(showVersion);
            versionAndCapitals.AddSubMenu(showUpperNumber);
        }

        internal static void RunDelegatesMenu(Delegates.MainMenu i_DelegatesMenu)
        {
            i_DelegatesMenu.Show();
        }

        internal static void ShowDateAction(Delegates.MenuItem i_Item)
        {
            Console.WriteLine(string.Format($"The Date is: {DateTime.Today:d}"));
        }

        internal static void ShowTimeAction(Delegates.MenuItem i_Item)
        {
            Console.WriteLine(string.Format($"The Hour is: {DateTime.Now:HH:mm:ss}"));
        }

        internal static void ShowVersionAction(Delegates.MenuItem i_Item)
        {
            Console.WriteLine("Version: 23.3.4.9835");
        }

        internal static void ShowUpperNumberAction(Delegates.MenuItem i_Item)
        {
            Console.WriteLine("Please enter your sentence");
            string inputString = Console.ReadLine();
            Console.WriteLine(string.Format($"There are {countUpper(inputString)} capitals in your sentence."));
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