using Xamarin.Forms;

namespace EntryUnfocus.WPF
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new EntryUnfocus.App());
        }
    }
}
