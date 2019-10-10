namespace MutualMyPJHPApp
{
    using MutualMyPJHPApp.Pages;
    using Xamarin.Forms;
    using MutualMyPJHPApp.Services;
    using MutualMyPJHPApp.Models;
    using System;
    using MutualMyPJHPApp.ViewModels;

    public partial class App : Application
    {
        #region Attributes
        //private DataService dataService;
        #endregion

        #region Properties
        public static NavigationPage Navigator { get; internal set; }
        //public static MasterPage Master { get; internal set; }
        #endregion

        #region Constructor
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
            //dataService = new DataService();
            LoadParameters();

            //var user = dataService.First<User2>(false);
            //if (user != null) // && user.IsRemembered && user.TokenExpires > DateTime.Now)
            //{
            //    var mainViewModel = MainViewModel.GetInstance();
            //    mainViewModel.CurrentUser = user;
            //    MainPage = new MasterPage();
            //}
            //else
            //{

            //}

        }
        #endregion

        #region Methods
        private void LoadParameters()
        {
            var urlBase = Application.Current.Resources["URLBase"].ToString();
            //var parameter = dataService.First<Parameter>(false);
            //if (parameter == null)
            //{
            //    parameter = new Parameter
            //    {
            //        URLBase = urlBase,
            //    };

            //    dataService.Insert(parameter);
            //}
            //else
            //{
            //    parameter.URLBase = urlBase;
            //    dataService.Update(parameter);
            //}
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion
    }
}