namespace AnimalManagementSystem.View;

public partial class Fourrage : ContentPage
{
	public Fourrage()
	{
		InitializeComponent();
	}
    private async void OnOption1Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///option1");
    }

    private async void OnOption2Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///option2");
    }

}