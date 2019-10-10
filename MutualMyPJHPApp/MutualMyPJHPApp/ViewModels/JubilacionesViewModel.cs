namespace MutualMyPJHPApp.ViewModels
{
    using MutualMyPJHPCommon.Models;
    using MutualMyPJHPApp.Services;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class JubilacionesViewModel : BaseViewModel
    {
        #region Attributes
        private ApiService apiService;
        //private DataService dataService;
        private DialogService dialogService;
        private NavigationService navigationService;
        private ObservableCollection<JubilacionItemViewModel> jubilaciones;
        private bool isRefreshing = false;
        private bool isToogled;
        private string filter;
        

        #endregion

        #region Properties
        
        public ObservableCollection<JubilacionItemViewModel> Jubilaciones
        {
            get { return this.jubilaciones; }
            set { this.SetValue(ref this.jubilaciones, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }
        public bool IsToogled
        {
            get { return this.isToogled; }
            set { this.SetValue(ref this.isToogled, value); }
        }
        public string Filter
        {
            get { return this.filter; }
            set
            {
                this.filter = value;
                this.RefreshList();
            }
        }
        public List<Jubilacion> MyJubilaciones { get; set; }
        #endregion

        #region Constructor
        public JubilacionesViewModel()
        {
            instance = this;
            apiService = new ApiService();
            dialogService = new DialogService();
            navigationService = new NavigationService();
            //dataService = new DataService();
            //this.dataService = new DataService();
            this.LoadJubilaciones();
            Jubilaciones = new ObservableCollection<JubilacionItemViewModel>();

        }

        private async void LoadJubilaciones()
        {
            //IsRefreshing = true;
            //var user = dataService.First<User>(false);
            var mainViewModel = MainViewModel.GetInstance();
            var controller = string.Format("/Jubilacions/GetJubilacions/{0}", mainViewModel.CurrentUser.ID);
            var response = await apiService.Get<Jubilacion>(
                "http://keypress.serveftp.net:88/MutualMyPJHPApi/",
                "api",
                controller);
            //mainViewModel.CurrentUser.IDUser);
            IsRefreshing = false;

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Aceptar");
                return;
            }



            this.MyJubilaciones = (List<Jubilacion>)response.Result;

            RefreshList();
            IsRefreshing = false;

        }

        public void RefreshList()
        {
            
                var myListJubilacionItemViewModel = this.MyJubilaciones.Select(o => new JubilacionItemViewModel
                {
                    Art35=o.Art35,
                    AyudaCapital=o.AyudaCapital,
                    AyudaInterés=o.AyudaInterés,
                    Año=o.Año,
                    Benef1=o.Benef1,
                    Beneficiario=o.Beneficiario,
                    BienesPerson=o.BienesPerson,
                    CajaMédicos=o.CajaMédicos,
                    CoberturaOdontol=o.CoberturaOdontol,
                    CoberturaSalud=o.CoberturaSalud,
                    Cochera=o.Cochera,
                    Cuenta=o.Cuenta,
                    CuotaNro=o.CuotaNro,
                    CuotaSocial=o.CuotaSocial,
                    DescuentosAMMPJHPC=o.DescuentosAMMPJHPC,
                    DescuentosHP=o.DescuentosHP,
                    DNI=o.DNI,
                    Donación=o.Donación,
                    EntregadoPorMail=o.EntregadoPorMail,
                    Farmacia=o.Farmacia,
                    FechaEntregado=o.FechaEntregado,
                    FechaPago= o.FechaPago,
                    FechaPago1=o.FechaPago1,
                    FechaPago2=o.FechaPago2,
                    FotocopBibliot=o.FotocopBibliot,
                    GastosVarios=o.GastosVarios,
                    ID=o.ID,
                    IdJub=o.IdJub,
                    IndiceJub=o.IndiceJub,
                    LiquidoACobrar=o.LiquidoACobrar,
                    Mes=o.Mes,
                    Minoli=o.Minoli,
                    MontoBeneficio=o.MontoBeneficio,
                    MutualEHP=o.MutualEHP,
                    Pagada=o.Pagada,
                    Pago1=o.Pago1,
                    Pago2=o.Pago2,
                    Recibo=o.Recibo,
                    ReciboEntregado=o.ReciboEntregado,
                    RescateAcciones=o.RescateAcciones,
                    RetenciónImpGanancias=o.RetenciónImpGanancias,
                    RevistaHP=o.RevistaHP,
                    SAcc=o.SAcc,
                    SaldoNegativo=o.SaldoNegativo,
                    SeguroCNAYS=o.SeguroCNAYS,
                    SeguroConyuge=o.SeguroConyuge,
                    SeguroPrivado=o.SeguroPrivado,
                    SEnf=o.SEnf,
                    SubsidioFallecimiento=o.SubsidioFallecimiento,
                    TipoBeneficio=o.TipoBeneficio,
                    VariosHP=o.VariosHP,
                });
                this.Jubilaciones = new ObservableCollection<JubilacionItemViewModel>(myListJubilacionItemViewModel.Where(
                        o => o.Año != 1900).OrderBy(o => o.Mes));
        }

        #endregion

        #region Singleton

        private static JubilacionesViewModel instance;
        public static JubilacionesViewModel GetInstance()
        {
            return instance;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadJubilaciones);
            }
        }
        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand(RefreshList);
            }
        }
   
        
        #endregion

    }
}