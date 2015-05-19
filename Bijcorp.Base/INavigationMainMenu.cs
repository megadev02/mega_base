namespace Bijcorp.Base
{
    public interface INavigationMainMenu
    {        
        IGenericPresenter CurrentPresenter { get; set; }
        void RefreshButtonConfig();
    }
}