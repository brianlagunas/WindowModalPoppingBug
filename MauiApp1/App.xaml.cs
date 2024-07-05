using MauiApp1.Views;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new MyWindow(new ViewA() { Title = "View A"});
        }
    }

    public class MyWindow : Window
    {
        public MyWindow(Page page) : base(page)
        {
            ModalPopping += PrismWindow_ModalPopping;
        }

        private void PrismWindow_ModalPopping(object? sender, ModalPoppingEventArgs e)
        {
            e.Cancel = true; //closes the app on Android hardware back button
        }
    }
}
