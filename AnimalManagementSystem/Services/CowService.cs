using AnimalManagementSystem.Entity;
using AnimalManagementSystem.Infra;

namespace AnimalManagementSystem.Services
{
    public class CowService
    {
        private readonly DatabaseService _databaseService;

        public CowService()
        {
            _databaseService = new DatabaseService();
        }

        public bool AddCow(string tag, float poids, int age)
        {
            if (string.IsNullOrWhiteSpace(tag) || poids <= 0 || age <= 0)
                return false;

            var cow = new Cow
            {
                Tag = tag,
                Poids = poids,
                Age = age
            };

            _databaseService.AddCow(cow);
            return true;
        }
    }
}
