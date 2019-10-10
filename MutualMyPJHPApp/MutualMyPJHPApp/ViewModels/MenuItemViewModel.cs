using GalaSoft.MvvmLight.Command;
using MutualMyPJHPApp.Services;
using System.Windows.Input;
using MutualMyPJHPApp.ViewModels;

namespace ViewModels
{
    public class MenuItemViewModel
    {
        #region Attributes
        private NavigationService navigationService;
        //private DataService dataService;
        #endregion
        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        #endregion

        #region Commands
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {
            var mainViewModel = MainViewModel.GetInstance();
            if (PageName == "LoginPage")
            {
                //mainViewModel.CurrentUser.IsRemembered = false;
                //dataService.Update(mainViewModel.CurrentUser);
                navigationService.SetMainPage("LoginPage");
            }
            else
            {
                switch (PageName)
                {
                    case "JubilacionesPage":
                        mainViewModel.Jubilaciones = new JubilacionesViewModel();
                        await navigationService.Navigate(PageName);
                        break;
                    //case "RemotesPage":
                    //    mainViewModel.Remotes = new RemotesViewModel();
                    //    await navigationService.Navigate(PageName);
                    //    break;
                    case "ConfigPage":
                        //mainViewModel.Config = new ConfigViewModel(mainViewModel.CurrentUser);
                        await navigationService.Navigate(PageName);
                        break;

                    default:
                        break;
                }
            }
        }
        #endregion

        #region Constructors
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
            //dataService = new DataService();
        }
        #endregion
    }
}
