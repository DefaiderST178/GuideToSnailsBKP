namespace GuideToSnailsBKP.View;

public partial class SelectedCare : ContentPage
{
	public SelectedCare(Model.Care selectedCare)
	{
		InitializeComponent();
        BindingContext = selectedCare;
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}