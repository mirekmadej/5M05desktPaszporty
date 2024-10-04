
namespace _5M05desktPaszporty
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window();
            window.MaximumHeight = 500;
            window.MinimumHeight = 500;
            window.MaximumWidth = 800;
            window.MinimumWidth = 800;
            window.Title = "Wprowadzenie danych do paszportu. Wykonał: 000000000";
            window.Page = new AppShell();
            return window;
            
        }
    }
}
