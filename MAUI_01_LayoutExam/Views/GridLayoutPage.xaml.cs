namespace MAUI_01_LayoutExam.Views;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}
    
    private void OkBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

   
}