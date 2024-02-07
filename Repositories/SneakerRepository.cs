using SneakerSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerSpot.Repositories
{
    public class SneakerRepository : ISneakerRepository
    {
        private static List<Sneaker> _sneakers = new List<Sneaker>();

        public IEnumerable<Sneaker> GetAll() => _sneakers;

        public Sneaker GetById(int id) => _sneakers.FirstOrDefault(s => s.Id == id);
    }

}
