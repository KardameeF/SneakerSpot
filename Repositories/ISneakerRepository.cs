using SneakerSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerSpot.Repositories
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> GetAll();
        Sneaker GetById(int id);
    }

}
