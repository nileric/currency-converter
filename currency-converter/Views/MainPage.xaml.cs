using System;
using System.Linq;
using Windows.UI.Xaml.Controls;

namespace currency_converter.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // Preventing non-digit input
        // The task text says that only standard controls should be used. Otherwise, it is possible to use NumberBox
        // https://docs.microsoft.com/en-us/windows/uwp/design/controls-and-patterns/number-box
        private void TextBox_OnBeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            if (args.NewText == string.Empty)
            {
                sender.Text = string.Empty;
            }
            else
            {
                bool isDouble = double.TryParse(args.NewText, out _);
                bool isNegative = args.NewText.Any(c => c == '-');
                args.Cancel = !isDouble || isNegative;
            }
        }
    }
}
