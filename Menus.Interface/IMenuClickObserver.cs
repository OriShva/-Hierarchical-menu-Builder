namespace Menus.Interfaces
{
    internal interface IMenuClickObserver
    {
        void ReportClicked(Menus.Interfaces.MenuItem i_Item);
    }
}