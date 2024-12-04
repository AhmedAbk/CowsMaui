using System.Windows.Input;

namespace AnimalManagementSystem
{
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateToAnimalCommand { get; }
        public ICommand NavigateToAddCowCommand { get; }
        public ICommand NavigateToRatioCommand { get; }
        public MainPage()
        {
            InitializeComponent();

            NavigateToAnimalCommand = new Command(OnNavigateToAnimal);
            NavigateToAddCowCommand = new Command(OnNavigateToAdd);
            NavigateToRatioCommand = new Command(OnNavigateRatio);
            BindingContext = this;
        }

        private async void OnNavigateToAnimal()
        {
            await Shell.Current.GoToAsync("AnimalPage");
        }
        private async void OnNavigateToAdd()
        {
            await Shell.Current.GoToAsync("//AddPage");
        }
        private async void OnNavigateRatio()
        {
            await Shell.Current.GoToAsync("calculRation");
        }

    }

}
