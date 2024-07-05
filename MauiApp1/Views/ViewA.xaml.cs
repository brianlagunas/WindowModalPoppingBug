namespace MauiApp1.Views;

public partial class ViewA : ContentPage
{
	public ViewA()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new ViewB());
        Navigation.PushModalAsync(new ViewB());
    }
}