using CommonServiceLocator;
using currency_converter.Network;
using currency_converter.Repository;
using currency_converter.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace currency_converter.ViewModels
{
    public class ViewModelLocator
    {
        public const string MainPageKey = "MainPage";
        public const string CurrencySelectionPageKey = "CurrencySelectionPage";

        public MainPageViewModel MainPageInstance => ServiceLocator.Current.GetInstance<MainPageViewModel>();

        public CurrencySelectionPageViewModel CurrencySelectionPageInstance =>
            ServiceLocator.Current.GetInstance<CurrencySelectionPageViewModel>();

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var nav = new NavigationService();
            nav.Configure(MainPageKey, typeof(MainPage));
            nav.Configure(CurrencySelectionPageKey, typeof(CurrencySelectionPage));

            // Singletons by default
            SimpleIoc.Default.Register<INavigationService>(() => nav);
            SimpleIoc.Default.Register<IApiService, ApiService>();
            SimpleIoc.Default.Register<ICurrencyRepository, CurrencyRepository>();
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<CurrencySelectionPageViewModel>();
        }
    }
}