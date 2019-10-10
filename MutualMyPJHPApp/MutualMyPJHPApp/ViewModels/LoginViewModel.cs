using GalaSoft.MvvmLight.Command;
using Plugin.Connectivity;
using MutualMyPJHPApp.Models;
using MutualMyPJHPApp.Services;
using System.ComponentModel;
using System.Windows.Input;
using MutualMyPJHPApp.ViewModels;

namespace MutualMyPJHPApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private ApiService apiService;
        private DialogService dialogService;
        //private DataService dataService;
        private NavigationService navigationService;
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        private bool isRemembered;


        #endregion

        #region Properties
        public string Email
        {
            set
            {
                if (email != value)
                {
                    email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
                }
            }
            get
            {
                return email;
            }
        }

        public string Password
        {
            set
            {
                if (password != value)
                {
                    password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                }
            }
            get
            {
                return password;
            }
        }

        public bool IsRunning
        {
            set
            {
                if (isRunning != value)
                {
                    isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRunning"));
                }
            }
            get
            {
                return isRunning;
            }
        }

        public bool IsEnabled
        {
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsEnabled"));
                }
            }
            get
            {
                return isEnabled;
            }
        }

        public bool IsRemembered
        {
            set
            {
                if (isRemembered != value)
                {
                    isRemembered = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRemembered"));
                }
            }
            get
            {
                return isRemembered;
            }
        }

        #endregion

        #region constructors
        public LoginViewModel()
        {
            apiService = new ApiService();
            dialogService = new DialogService();
            //dataService = new DataService();
            navigationService = new NavigationService();
            IsRemembered = true;
            IsEnabled = true;
            Email = null;
            Password = null;

            //Email = "Demo";
            //Password = "Demo";// null;
        }
        #endregion


        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new RelayCommand(Login); } }
       

        

        private async void Login()
        {
            if (string.IsNullOrEmpty(Email))
            {
                await dialogService.ShowMessage("Error", "Debe ingresar un Usuario.");
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await dialogService.ShowMessage("Error", "Debe ingresar una Contraseña.");
                return;
            }

            IsRunning = true;
            IsEnabled = false;

            if (!CrossConnectivity.Current.IsConnected)
            {
                IsRunning = false;
                IsEnabled = true;
                await dialogService.ShowMessage("Error", "Chequee su conexión a Internet.");
                return;
            }

            //var parameters = dataService.First<Parameter>(false);

            var response = await apiService.GetUserByEmail(
                "http://keypress.serveftp.net:88/MutualMyPJHPAPI/",
                "api",
                "/SubContratistasUsrWebs/GetUserByEmail",
                Email);



            if (!response.IsSuccess)
            {
                IsRunning = false;
                IsEnabled = true;
                await dialogService.ShowMessage("Error", "El Usuario o Contraseña son incorrectos");
                return;
            }

            var user = (User2)response.Result;


            if (!(user.Password.ToLower() == Password.ToLower()))
            {
                IsRunning = false;
                IsEnabled = true;
                await dialogService.ShowMessage("Error", "El Usuario o Contraseña son incorrectos");
                return;
            }

           


            //user.IsRemembered = IsRemembered;
            //user.Contrasena = Password;
            //dataService.DeleteAllAndInsert(user);

            Email = null;
            Password = null;

            IsRunning = false;
            IsEnabled = true;


            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.CurrentUser = user;
            navigationService.SetMainPage("MasterPage");

        }
        #endregion
    }
}
