using AnimalManagementSystem.Services;

namespace AnimalManagementSystem
{
    public partial class AddCow : ContentPage
    {
        private readonly CowService _cowService;

        public AddCow()
        {
            InitializeComponent();
            _cowService = new CowService();

        }

        private void OnAddCowClicked(object sender, EventArgs e)
        {
            string tag = TagEntry.Text;
            bool poidsParsed = float.TryParse(poidsEntry.Text, out float poids);
            bool ageParsed = int.TryParse(AgeEntry.Text, out int age);

            if (poidsParsed && ageParsed)
            {
                bool success = _cowService.AddCow(tag, poids, age);
                if (success)
                {
                    DisplayAlert("Success", "Cow added successfully!", "OK");
                    TagEntry.Text = string.Empty;
                    poidsEntry.Text = string.Empty;
                    AgeEntry.Text = string.Empty;
                }
                else
                {
                    DisplayAlert("Error", "Invalid data. Please check your inputs.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Please enter valid poids and age.", "OK");
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
