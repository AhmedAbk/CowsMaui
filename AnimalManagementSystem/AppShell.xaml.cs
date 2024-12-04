namespace AnimalManagementSystem
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("AnimalPage", typeof(SecondPage));
            Routing.RegisterRoute("AddPage", typeof(AddCow));
            Routing.RegisterRoute("calculRation", typeof(calculRation));
            Routing.RegisterRoute("fourage", typeof(Fourrage));
            Routing.RegisterRoute("concentre", typeof(Concentre));
            Routing.RegisterRoute("cfourage", typeof(cfourrage));


        }
    }
}
