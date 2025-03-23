using GuideToSnailsBKP.Model;

namespace GuideToSnailsBKP.View;

public partial class SnailsGuide : ContentPage
{
	public SnailsGuide()
	{
		InitializeComponent();
        BindingContext = SnailRepo.AllSnails;
    }
    private void snailsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        // Получаем выбранную улитку из списка
        var selectedSnail = e.SelectedItem as Snail;

        // Открываем новую страницу с информацией об улитке
        Navigation.PushAsync(new SelectedSnail(selectedSnail));

        // Сбрасываем выбор в списке
        snailsList.SelectedItem = null;
    }
}