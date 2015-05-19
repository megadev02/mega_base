using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bijcorp.Base
{
    public interface IGenericView : INotifyPropertyChanged
    {
        INavigationMainMenu NavigationMainMenu { get; set; }
        Operation CurrentOperation { get; set; }
        Button NewMenuButton { get; }
        Button SearchMenuButton { get; }

        event EventHandler NewMenuButtonClicked;
        event EventHandler SearchMenuButtonClicked;
        event EventHandler AddClicked;
        event EventHandler UpdateClicked;
        event EventHandler SearchClicked;
        event EventHandler CancelClicked;
        event EventHandler OkClicked;
        event EventHandler ActivatedFormClicked;

        IGenericPresenter GetPresenter();
    }

    public enum Operation
    {
        Add,
        Update,
        Search,
        Ok,
        Nothing
    }
}
