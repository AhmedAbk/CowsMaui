namespace AnimalManagementSystem;

public partial class cfourrage : ContentPage
{
	public cfourrage()
	{
		InitializeComponent();
	}
	private async void OnCalculateClicked(object sender, EventArgs e)
    { 
        if (double.TryParse(CIEntry.Text, out double ci))
        { 
            double totalKgMs = 0;
             
            double kgMB1 = 10; // Example: replace with dynamic input
            double ms1 = 88; // Example: replace with dynamic %MS for the first forage
            totalKgMs += kgMB1 * (ms1 / 100);

            double kgMB2 = 5; // Example: replace with dynamic input
            double ms2 = 13; // Example: replace with dynamic %MS for the second forage
            totalKgMs += kgMB2 * (ms2 / 100);

            // Add more forages as needed

            // Display the result (sum of all Kg MS values)
            ResultLabel.Text = $"Total Kg MS: {totalKgMs}";

            // Compare with the CI and show appropriate alert
            if (totalKgMs < ci)
            {
                await DisplayAlert("Alert", "The capacity of ingestion is not saturated. Increase the quantity of forages.", "OK");
            }
            else if (totalKgMs > ci)
            {
                await DisplayAlert("Alert", "The capacity of ingestion is exceeded. Decrease the quantity of forages.", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "The capacity of ingestion is perfectly matched.", "OK");
            }
        }
        else
        {
            await DisplayAlert("Error", "Please enter a valid CI value.", "OK");
        }
    }

}