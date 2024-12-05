using AnimalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem.Model
{
    public static class ForageData
    {
        public static List<Forage> GetDefaultForages()
        {
            return new List<Forage>
        {
            new Forage { Name = "Betteraves Fourragères", PercentageMS = 13 },
            new Forage { Name = "Paille de Pois", PercentageMS = 86 },
            new Forage { Name = "Paille d'Avoine", PercentageMS = 88 },
            new Forage { Name = "Paille d'Orge", PercentageMS = 88 },
            new Forage { Name = "Paille de Blé", PercentageMS = 88 },
            new Forage { Name = "Paille de Colza", PercentageMS = 88 }
        };
        }
    }
}
