using MutualMyPJHPApp.Services;
using MutualMyPJHPCommon.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualMyPJHPApp.ViewModels
{
    public class JubilacionViewModel : BaseViewModel
    {
        #region Attributes
        private Jubilacion jubilacion;
        private ApiService apiService;
        private DialogService dialogService;
        //private DataService dataService;
        private NavigationService navigationService;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Properties
        
        public Jubilacion Jubilacion
        {
            get { return this.jubilacion; }
            set { this.SetValue(ref this.jubilacion, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { this.SetValue(ref this.isRunning, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { this.SetValue(ref this.isEnabled, value); }
        }
       
        #endregion

        #region Constructors
        public JubilacionViewModel(Jubilacion jubilacion)
        {
            
            instance = this;
            this.jubilacion = jubilacion;
            apiService = new ApiService();
            dialogService = new DialogService();
            //dataService = new DataService();
            navigationService = new NavigationService();
            this.IsEnabled = true;
         
        }

        #endregion
        #region Singleton

        private static JubilacionViewModel instance;
        public static JubilacionViewModel GetInstance()
        {
            return instance;
        }
        #endregion

    }






}
