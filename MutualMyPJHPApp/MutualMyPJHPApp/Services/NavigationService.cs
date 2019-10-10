namespace MutualMyPJHPApp.Services
{
    using Pages;
    using System.Threading.Tasks;

    public class NavigationService
    {
        #region Methods
        public void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                //case "MasterPage":
                //    App.Current.MainPage = new MasterPage();
                //    break;
                //case "LoginPage":
                //    //Logout();
                //    App.Current.MainPage = new LoginPage();
                //    break;
                //case "NewUserPage":
                //    App.Current.MainPage = new NewUserPage();
                //    break;
                //case "ForgotPasswordPage":
                //    App.Current.MainPage = new ForgotPasswordPage();
                //    break;




                //default:
                //    break;
            }
        }

        public async Task Navigate(string pageName)
        {
            //App.Master.IsPresented = false;
            switch (pageName)
            {
                //case "OrdersPage":
                //    await App.Navigator.PushAsync(new OrdersPage());
                //    break;
                //case "RemotesPage":
                //    await App.Navigator.PushAsync(new RemotesPage());
                //    break;
                //case "ConfigPage":
                //    await App.Navigator.PushAsync(new ConfigPage());
                //    break;
                //case "ChangePasswordPage":
                //    await App.Navigator.PushAsync(new ChangePasswordPage());
                //    break;
                //case "OrderPage":
                //    await App.Navigator.PushAsync(new OrderPage());
                //    break;
                //case "TakePicturePage":
                //    await App.Navigator.PushAsync(new TakePicturePage());
                //    break;
                //case "DNIPicturePage":
                //    await App.Navigator.PushAsync(new DNIPicturePage());
                //    break;
                //case "FirmaPage":
                //    await App.Navigator.PushAsync(new FirmaPage());
                //    break;
                //case "OrderPicturesPage":
                //    await App.Navigator.PushAsync(new OrderPicturesPage());
                //    break;
                //case "PicturePage":
                //    await App.Navigator.PushAsync(new PicturePage());
                //    break;
                //default:
                //    break;
                //case "OrdersMapPage":
                //    await App.Navigator.PushAsync(new OrdersMapPage());
                //    break;
                //case "RemotesMapPage":
                //    await App.Navigator.PushAsync(new RemotesMapPage());
                //    break;
                //case "OrderMapPage":
                //    await App.Navigator.PushAsync(new OrderMapPage());
                //    break;
                //case "RemoteMapPage":
                //    await App.Navigator.PushAsync(new RemoteMapPage());
                //    break;


            }
        }
        public async Task Back()
        {
            await App.Navigator.PopAsync();
        }
        #endregion
    }
}