using currency_converter.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using System.Collections.Generic;
using System.Windows.Input;

namespace currency_converter.ViewModels
{
    public class CurrencySelectionPageViewModel : ViewModelBase
    {
        private readonly ICurrencyRepository _repository;
        private readonly INavigationService _navigationService;

        private Currency _selectedItem;
        public Currency SelectedItem
        {
            get => _selectedItem;
            set => Set(ref _selectedItem, value);
        }

        private IEnumerable<Currency> _currencies;
        public IEnumerable<Currency> Currencies
        {
            get => _currencies;
            set => Set(ref _currencies, value);
        }

        private ICommand _itemSelectCommand;
        public ICommand ItemSelectCommand
        {
            get
            {
                if (_itemSelectCommand == null)
                {
                    _itemSelectCommand = new RelayCommand(ItemSelectCommandAction);
                }
                return _itemSelectCommand;
            }
        }

        private ICommand _navigateCommand;
        public ICommand NavigateCommand
        {
            get
            {
                if (_navigateCommand == null)
                {
                    _navigateCommand = new RelayCommand(NavigateCommandAction);
                }
                return _navigateCommand;
            }
        }

        public CurrencySelectionPageViewModel(INavigationService navigationService, ICurrencyRepository repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            LoadCurrencies();
        }

        private void NavigateCommandAction()
        {
            _navigationService.GoBack();
        }

        private void ItemSelectCommandAction()
        {
            MessengerInstance.Send(new NotificationMessage<string>(SelectedItem.CharCode, "selected new currency"));
            _navigationService.GoBack();
        }

        private async void LoadCurrencies()
        {
            Currencies = await _repository.GetCurrenciesAsync();
        }
    }
}