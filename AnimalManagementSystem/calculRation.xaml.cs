namespace AnimalManagementSystem;

public partial class calculRation : ContentPage
{
	public calculRation()
	{
		InitializeComponent();
	}
    private async void OnFourageClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///fourage");
    }

    private async void OnConcentreClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///concentre");
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}