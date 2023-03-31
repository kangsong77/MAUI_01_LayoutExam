using System.Collections.ObjectModel;

namespace MAUI_01_LayoutExam.Views;

public partial class FlexLayoutPage : ContentPage
{
    public ObservableCollection<string> Items { get; set; } = new() { "û�ұ�", "���������", "������", "��Ǽ���", "�д�ɷ�", "���尩", "�ֹ漼��", "�ɷ�" };
    public FlexLayoutPage()
	{
		InitializeComponent();

        BindingContext = this;
    }

    private void OkBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}