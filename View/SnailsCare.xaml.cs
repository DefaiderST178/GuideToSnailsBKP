using GuideToSnailsBKP.Model;

namespace GuideToSnailsBKP.View;

public partial class SnailsCare : ContentPage
{
	public SnailsCare()
	{
		InitializeComponent();
        BindingContext = CareRepo.AllCare;
    }

    private void CareList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        // Получаем выбранную улитку из списка
        var selectedCare = e.SelectedItem as Care;

        // Открываем новую страницу с информацией об улитке
        Navigation.PushAsync(new SelectedCare(selectedCare));

        // Сбрасываем выбор в списке
        CareList.SelectedItem = null;
    }
}