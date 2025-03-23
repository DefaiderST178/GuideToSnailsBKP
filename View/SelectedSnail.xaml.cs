namespace GuideToSnailsBKP.View;

public partial class SelectedSnail : ContentPage
{
	public SelectedSnail(Model.Snail selectedSnail)
	{
		InitializeComponent();
        BindingContext = selectedSnail;
    }
    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}