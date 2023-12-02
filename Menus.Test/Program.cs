using System;

namespace Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu interfaceMainMenu = new Interfaces.MainMenu("Interface Menu");
            TestInterface.CreateInterfacesMenu(interfaceMainMenu);
            TestInterface.RunInterfacesMenu(interfaceMainMenu);
            Console.Clear();

            Delegates.MainMenu delegateMainMenu = new Delegates.MainMenu("Delegate Menu");
            TestDelegate.CreateDelegatesMenu(delegateMainMenu);
            TestDelegate.RunDelegatesMenu(delegateMainMenu);
        }
    }
}