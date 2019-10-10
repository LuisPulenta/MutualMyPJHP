namespace MutualMyPJHPApp.ViewModels
{
    using MutualMyPJHPCommon.Models;
    using MutualMyPJHPApp.Pages;
    using MutualMyPJHPApp.Services;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    public class JubilacionItemViewModel : Jubilacion
    {
        #region Atributtes
        public ApiService apiService;
        private NavigationService navigationService;
        #endregion
        #region Constructors
        public JubilacionItemViewModel()
        {
            this.apiService = new ApiService();
            navigationService = new NavigationService();
        }
        #endregion
        #region Commands
        public ICommand SelectRemoteCommand { get { return new RelayCommand(SelectRemote); } }
        private async void SelectRemote()
        {
            MainViewModel.GetInstance().Jubilacion = new JubilacionViewModel(this);
            await App.Navigator.PushAsync(new JubilacionPage());
        }
        #endregion
    }
}