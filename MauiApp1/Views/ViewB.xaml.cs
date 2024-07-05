namespace MauiApp1.Views;

public partial class ViewB : ContentPage
{
	public ViewB()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new ViewC());
        Navigation.PushModalAsync(new ViewC());
    }
}