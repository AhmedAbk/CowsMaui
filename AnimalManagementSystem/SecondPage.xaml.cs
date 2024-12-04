namespace AnimalManagementSystem;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}