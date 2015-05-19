using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bijcorp.Base
{
    public class GenericPresenter : IGenericPresenter
    {
        private IGenericView _genericView = null;
        private INavigationMainMenu _navigationMainMenu = null;

        public GenericPresenter(IGenericView genericView, INavigationMainMenu navigationMainMenu)
        {
            _genericView = genericView;
            _navigationMainMenu = navigationMainMenu;
            InitializeFlags();

            _genericView.NewMenuButtonClicked += _genericView_NewMenuButtonClicked;
            _genericView.SearchMenuButtonClicked += _genericView_SearchMenuButtonClicked;
            _genericView.AddClicked += _genericView_AddClicked;
            _genericView.UpdateClicked += _genericView_UpdateClicked;
        }

        void _genericView_SearchMenuButtonClicked(object sender, EventArgs e)
        {
            try
            {
                if (Search() == DialogResult.OK)
                {
                    //cambiar a estado de modificar
                    RetrieveOfSearch();
                    Clear();
                    Retrieve();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            
        }

        void _genericView_NewMenuButtonClicked(object sender, EventArgs e)
        {
            Clear();
        }        
        
        void _genericView_UpdateClicked(object sender, EventArgs e)
        {
            try
            {
                if (AllRightUpdate())
                {
                    Update();
                    Clear();
                    InitializeFlags();
                    if (_navigationMainMenu != null)
                        _navigationMainMenu.RefreshButtonConfig();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //almacenar en log
            }            
        }

        void _genericView_AddClicked(object sender, EventArgs e)
        {
            try
            {
                if (AllRightAdd())
                {
                    Add();
                    Clear();
                    InitializeFlags();
                    if (_navigationMainMenu != null)
                        _navigationMainMenu.RefreshButtonConfig();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //almacenar en log
            }
        }

        public bool FlagButtonNew { get; set; }
        public bool FlagButtonSearch { get; set; }
        public bool FlagButtonFilter { get; set; }
        public bool FlagButtonNavigation { get; set; }

        public void InitializeProperties()
        {
            throw new NotImplementedException();
        }

        public void InitializeFlags()
        {
            FlagButtonSearch = true;
            FlagButtonFilter = true;
            FlagButtonNew = false;
            FlagButtonNavigation = true;
            _genericView.CurrentOperation = Operation.Add;
        }

        public void FilterMenuButton()
        {
            //modificar campos para busqueda
            _genericView.CurrentOperation = Operation.Search;
            FlagButtonNavigation = true;
            FlagButtonNew = true;
            FlagButtonSearch = true;
            _navigationMainMenu.RefreshButtonConfig();
            _genericView.NewMenuButton.PerformClick();
        }

        public void SearchMenuButton()
        {            
            _genericView.SearchMenuButton.PerformClick();
        }

        public void RetrieveOfSearch()
        {
            //modificar para actualización
            _genericView.CurrentOperation = Operation.Update;
            FlagButtonNavigation = true;
            FlagButtonNew = true;
            FlagButtonSearch = true;
            _navigationMainMenu.RefreshButtonConfig();
        }

        public void NewMenuButton()
        {
            //modificar campos para ingresar nuevos campos
            _genericView.CurrentOperation = Operation.Add;
            FlagButtonNavigation = true;
            FlagButtonNew = false;
            FlagButtonSearch = true;            
            _navigationMainMenu.RefreshButtonConfig();  
            _genericView.NewMenuButton.PerformClick();
        }

        public void FirstMenuButton()
        {
            _genericView.CurrentOperation = Operation.Ok;
            FlagButtonNavigation = true;
            FlagButtonNew = true;
            FlagButtonSearch = true;
            _navigationMainMenu.RefreshButtonConfig();
        }

        public void PreviusMenuButton()
        {
            _genericView.CurrentOperation = Operation.Ok;
            FlagButtonNavigation = true;
            FlagButtonNew = true;
            FlagButtonSearch = true;
            _navigationMainMenu.RefreshButtonConfig();
        }

        public void NextMenuButton()
        {
            _genericView.CurrentOperation = Operation.Ok;
            FlagButtonNavigation = true;
            FlagButtonNew = true;
            FlagButtonSearch = true;
            _navigationMainMenu.RefreshButtonConfig();
        }

        public void LastMenuButton()
        {
            _genericView.CurrentOperation = Operation.Ok;
            FlagButtonNavigation = true;
            FlagButtonNew = true;
            FlagButtonSearch = true;
            _navigationMainMenu.RefreshButtonConfig();
        }        

        protected virtual DialogResult Search()
        {
            //abrir maestro de busqueda generico
            //tomar como filtros de busqueda los mismos campos 
            //del formulario

            //por el momento abrir el maestro de busqueda generico
            //o el que se construya.
            return DialogResult.Cancel;
        }

        protected virtual void Add()
        {
        }

        protected virtual void Update()
        {            
        }

        protected virtual void Retrieve()
        {            
        }

        protected virtual bool AllRightAdd()
        {
            return false;
        }

        protected virtual bool AllRightUpdate()
        {
            return false;
        }

        protected virtual void Clear()
        {            
        }
    }
}
