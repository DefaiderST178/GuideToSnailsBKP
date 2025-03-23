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

        // �������� ��������� ������ �� ������
        var selectedCare = e.SelectedItem as Care;

        // ��������� ����� �������� � ����������� �� ������
        Navigation.PushAsync(new SelectedCare(selectedCare));

        // ���������� ����� � ������
        CareList.SelectedItem = null;
    }
}