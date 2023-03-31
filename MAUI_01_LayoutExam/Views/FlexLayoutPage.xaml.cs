using System.Collections.ObjectModel;

namespace MAUI_01_LayoutExam.Views;

public partial class FlexLayoutPage : ContentPage
{
    public ObservableCollection<string> Items { get; set; } = new() { "청소기", "쓰레기봉투", "수세미", "욕실세제", "밀대걸레", "고무장갑", "주방세제", "걸레" };
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