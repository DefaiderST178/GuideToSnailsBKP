namespace GuideToSnailsBKP.View;

public partial class SnailPodbor : ContentPage
{
    public int ampulyriya = 0;
    public int melaniya = 0;
    public int neretina = 0;
    public int axatina = 0;
    public int katushka = 0;
    public int helena = 0;
    public int tilomelaniya = 0;
    public SnailPodbor()
	{
		InitializeComponent();
	}
    // ������ ���������
    private void ResultBtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            string answer = "";
            ResultTB.Text = "";
            // �������� 1
            if (Answer1_1.IsChecked == true)
            {
                ampulyriya++;
                melaniya++;
                katushka++;
            }
            else if (Answer1_2.IsChecked == true)
            {
                neretina++;
                helena++;
            }
            else if (Answer1_3.IsChecked == true)
            {
                axatina++;
                tilomelaniya++;
            }

            // �������� 2
            if (Answer2_1.IsChecked == true)
            {
                melaniya++;
                katushka++;
            }
            else if (Answer2_2.IsChecked == true)
            {
                ampulyriya++;
                neretina++;
                helena++;
            }
            else if (Answer2_3.IsChecked == true)
            {
                axatina++;
                tilomelaniya++;
            }

            // �������� 3
            if (Answer3_1.IsChecked == true)
            {
                ampulyriya++;
                melaniya++;
                katushka++;
            }
            else if (Answer3_2.IsChecked == true)
            {
                neretina++;
                helena++;
            }
            else if (Answer3_3.IsChecked == true)
            {
                axatina++;
                tilomelaniya++;
            }

            // �������� 4
            if (Answer4_1.IsChecked == true)
            {
                ampulyriya++;
                neretina++;
                katushka++;
            }
            else if (Answer4_2.IsChecked == true)
            {
                melaniya++;
            }
            else if (Answer4_3.IsChecked == true)
            {
                helena++;
                axatina++;
                tilomelaniya++;
            }

            // �������� 5
            if (Answer5_1.IsChecked == true)
            {
                ampulyriya++;
                neretina++;
                axatina++;
            }
            else if (Answer5_2.IsChecked == true)
            {
                melaniya++;
                katushka++;
                helena++;
            }
            else if (Answer5_3.IsChecked == true)
            {
                tilomelaniya++;
            }

            // ����������� ������������ ����������
            int[] values = new int[] { ampulyriya, melaniya, neretina, axatina, katushka, helena, tilomelaniya };
            string[] names = new string[] { "���������", "�������", "��������", "�������", "�������", "������", "�����������" };

            int maxIndex = 0;
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > values[maxIndex])
                    maxIndex = i;
            }

            // ����� �������� ������ � ������������ ���������
            ResultTB.Text = $"���������� ������: {names[maxIndex]}";

            // ����� �������
            ampulyriya = 0;
            melaniya = 0;
            neretina = 0;
            axatina = 0;
            katushka = 0;
            helena = 0;
            tilomelaniya = 0;
        }
        catch (Exception ex)
        {

        }
    }
}