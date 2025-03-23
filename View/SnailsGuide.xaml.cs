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

        // �������� ��������� ������ �� ������
        var selectedSnail = e.SelectedItem as Snail;

        // ��������� ����� �������� � ����������� �� ������
        Navigation.PushAsync(new SelectedSnail(selectedSnail));

        // ���������� ����� � ������
        snailsList.SelectedItem = null;
    }
}