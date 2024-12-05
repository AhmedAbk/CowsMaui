using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem.Entity
{
    public class Cow
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Tag {  get; set; }
        public float Poids { get; set; }

        public int Age { get; set; }

        public Cow() { }
        public Cow(string tag, float poids, int age) {
            this.Tag = tag;
            this.Poids = poids;
            this.Age = age;
        }
    }
}
