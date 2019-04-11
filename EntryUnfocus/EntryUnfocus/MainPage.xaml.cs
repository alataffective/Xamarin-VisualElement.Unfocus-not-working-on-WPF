using System.Diagnostics;
using System.Timers;
using Xamarin.Forms;

namespace EntryUnfocus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var timer = new Timer(3000);

            timer.Elapsed += (sender, args) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Debug.WriteLine("Entry.Unfocus");
                    Entry.Unfocus();
                });
            };

            timer.Start();
        }
    }
}
