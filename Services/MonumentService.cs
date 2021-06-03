using AspNetCore.Study.Models;
using System.Collections.Generic;

namespace AspNetCore.Study.Services
{
    public class MonumentService : IMonumentService
    {
        public void Create(Monument monument)
        {

        }

        public void Delete(int id)
        {

        }

        public IEnumerable<Monument> Get()
        {
            return new List<Monument>
            {
                new Monument {City="Tajavore", Name="Brihadeeshwara Temple", Id = 1, EntryFee = 100,StartHour=10,EndHour=18},
                new Monument {City="Agra", Name="Taj Mahal", Id=2,EntryFee=500,StartHour=10,EndHour=17}
            };
        }

        public Monument Get(int id)
        {
            return new Monument { City = "Tajavore", Name = "Brihadeeshwara Temple", Id = id, EntryFee = 100, StartHour = 10, EndHour = 18 };
        }

        public void Update(Monument monument)
        {
            
        }
    }
}
