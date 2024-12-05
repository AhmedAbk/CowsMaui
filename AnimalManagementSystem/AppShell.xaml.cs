using AnimalManagementSystem.View;

namespace AnimalManagementSystem
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("AnimalPage", typeof(SecondPage)); 
            Routing.RegisterRoute("Ratio", typeof(Ratio));    
            Routing.RegisterRoute("fourage", typeof(Fourrage));
            Routing.RegisterRoute("concentre", typeof(Concentre));
            Routing.RegisterRoute("cfourage", typeof(calculFourrage));


        }
    }
}
