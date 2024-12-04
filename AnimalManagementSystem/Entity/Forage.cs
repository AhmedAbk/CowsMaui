using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem.Entity
{
    public class Forage
    {
        public string Name { get; set; }
        public double PercentMS { get; set; } 
        public double KgMB { get; set; } 
        public double KgMS => KgMB * (PercentMS / 100); 
    }
}
