using MAUI_01_LayoutExam.Views;

namespace MAUI_01_LayoutExam;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}    

    private void gridLayout_Clicked(object sender, EventArgs e)
    {
        //페이지 Modal(백버튼 없음)
        Navigation.PushModalAsync(new GridLayoutPage());
    }

    private void bindableLayout_Clicked(object sender, EventArgs e)
    {
        
        Navigation.PushModalAsync(new BindableLayoutPage());
    }

    private void flexLayout_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new FlexLayoutPage());
    }

    private void final_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new FinalPage());
    }
}
