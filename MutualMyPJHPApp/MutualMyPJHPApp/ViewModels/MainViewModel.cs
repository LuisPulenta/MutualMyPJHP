namespace MutualMyPJHPApp.ViewModels
{
    using MutualMyPJHPCommon.Models;
    using MutualMyPJHPApp.Pages;
    using GalaSoft.MvvmLight.Command;

    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Input;
    using MutualMyPJHPApp.ViewModels;
    using global::ViewModels;

    public class MainViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private Usuario currentUser;
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Properties
        public LoginViewModel Login { get; set; }
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public JubilacionesViewModel Jubilaciones { get; set; }
        public JubilacionViewModel Jubilacion { get; set; }


    public Usuario CurrentUser
        {
            set
            {
                if (currentUser != value)
                {
                    currentUser = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentUser"));
                }
            }
            get
            {
                return currentUser;
            }
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            Login = new LoginViewModel();
            LoadMenu();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }

            return instance;
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_view_list.png",
                PageName = "JubilacionesPage",
                Title = "Recibos",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "",
                PageName = "",
                Title = "",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_exit_to_app.png",
                PageName = "LoginPage",
                Title = "Cerrar Sesión",
            });
        }
        #endregion
    }
}