using System.Collections.ObjectModel;

namespace MAUI_01_LayoutExam.Views;

public partial class BindableLayoutPage : ContentPage
{
    public ObservableCollection<string> Items1 { get; set; } = new() { "û�ұ�", "���������", "������", "��Ǽ���" };
    public ObservableCollection<string> Items2 { get; set; } = new() { "�д�ɷ�", "���尩", "�ֹ漼��", "�ɷ�" };
    List<string> items2 { get; set; }
    public BindableLayoutPage()
	{
		InitializeComponent();

        BindingContext = this;
	}

    private void OkBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}