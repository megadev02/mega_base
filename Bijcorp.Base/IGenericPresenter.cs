using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bijcorp.Base.Annotations;

namespace Bijcorp.Base
{
    public interface IGenericPresenter
    {        
        //propiedades        
        bool FlagButtonNew { get; set; }
        bool FlagButtonSearch { get; set; }
        bool FlagButtonFilter { get; set; }
        bool FlagButtonNavigation { get; set; }        

        //implementar en el presentador
        void InitializeProperties();
        void InitializeFlags();
        void FilterMenuButton();
        void SearchMenuButton();
        void RetrieveOfSearch();
        void NewMenuButton();
        void FirstMenuButton();
        void PreviusMenuButton();
        void NextMenuButton();
        void LastMenuButton();             
    }
}
