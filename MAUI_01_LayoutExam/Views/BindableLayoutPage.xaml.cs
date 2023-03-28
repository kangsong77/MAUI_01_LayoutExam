using System.Collections.ObjectModel;

namespace MAUI_01_LayoutExam.Views;

public partial class BindableLayoutPage : ContentPage
{
    public ObservableCollection<string> Items1 { get; set; } = new() { "청소기", "쓰레기봉투", "수세미", "욕실세제" };
    public ObservableCollection<string> Items2 { get; set; } = new() { "밀대걸레", "고무장갑", "주방세제", "걸레" };
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