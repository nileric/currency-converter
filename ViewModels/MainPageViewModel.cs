using currency_converter.Repository;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using System.Windows.Input;

namespace currency_converter.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ICurrencyRepository _repository;
        private readonly INavigationService _navigationService;

        private string _whichСurrency;

        private double _firstValue;
        public double FirstValue
        {
            get => _firstValue;
            set => Set(ref _firstValue, value);
        }

        private Currency _firstCurrency;
        public Currency FirstCurrency
        {
            get => _firstCurrency;
            set => Set(ref _firstCurrency, value);
        }

        private double _secondValue;
        public double SecondValue
        {
            get => _secondValue;
            set => Set(ref _secondValue, value);
        }

        private Currency _secondCurrency;
        public Currency SecondCurrency
        {
            get => _secondCurrency;
            set => Set(ref _secondCurrency, value);
        }

        private ICommand _navigateCommand;
        public ICommand NavigateCommand
        {
            get
            {
                if (_navigateCommand == null)
                {
                    _navigateCommand = new RelayCommand<string>(NavigateCommandAction);
                }
                return _navigateCommand;
            }
        }

        private ICommand _calculateFromFirstCommand;
        public ICommand CalculateFromFirstCommand
        {
            get
            {
                if (_calculateFromFirstCommand == null)
                {
                    _calculateFromFirstCommand = new RelayCommand(CalculateFromFirstCommandAction);
                }
                return _calculateFromFirstCommand;
            }
        }

        private ICommand _calculateFromSecondCommand;
        public ICommand CalculateFromSecondCommand
        {
            get
            {
                if (_calculateFromSecondCommand == null)
                {
                    _calculateFromSecondCommand = new RelayCommand(CalculateFromSecondCommandAction);
                }
                return _calculateFromSecondCommand;
            }
        }

        public MainPageViewModel(INavigationService navigationService, ICurrencyRepository repository)
        {
            _navigationService = navigationService;
            _repository = repository;

            MessengerInstance.Register<NotificationMessage<string>>(this, NotifyCurrencyChanged);

            FirstValue = 0;
            SecondValue = 0;
        }

        private void NavigateCommandAction(object parameter)
        {
            _whichСurrency = (string)parameter;
            _navigationService.NavigateTo(ViewModelLocator.CurrencySelectionPageKey);
        }

        private void CalculateFromFirstCommandAction()
        {
            if (FirstCurrency != null && SecondCurrency != null)
            {
                SecondValue = Calculate(FirstValue, FirstCurrency, SecondCurrency);
            }
        }
        private void CalculateFromSecondCommandAction()
        {
            if (FirstCurrency != null && SecondCurrency != null)
            {
                FirstValue = Calculate(SecondValue, SecondCurrency, FirstCurrency);
            }
        }

        private double Calculate(double FromValue, Currency FromCurrency, Currency ToCurrency)
        {
            return ((FromCurrency.Value * FromValue) / FromCurrency.Nominal) / (ToCurrency.Value / ToCurrency.Nominal);
        }


        private async void NotifyCurrencyChanged(NotificationMessage<string> notificationMessage)
        {
            string charCode = notificationMessage.Content;
            switch (_whichСurrency)
            {
                case "first":
                    FirstCurrency = await _repository.GetCurrencyByCharCodeAsync(charCode);
                    CalculateFromFirstCommandAction();
                    break;
                case "second":
                    SecondCurrency = await _repository.GetCurrencyByCharCodeAsync(charCode);
                    CalculateFromSecondCommandAction();
                    break;
                default:
                    break;
            }
        }
    }
}