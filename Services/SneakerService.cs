using SneakerSpot.Models;
using SneakerSpot.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerSpot.Services
{
    public class SneakerService
    {
        private readonly ISneakerRepository _sneakerRepository;

        public SneakerService(ISneakerRepository sneakerRepository)
        {
            _sneakerRepository = sneakerRepository;
        }

        public IEnumerable<Sneaker> GetAllSneakers() => _sneakerRepository.GetAll();
    }

}
