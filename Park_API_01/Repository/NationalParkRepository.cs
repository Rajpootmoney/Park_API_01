using Park_API_01.Models;
using Park_API_01.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Park_API_01.Repository
{
    public class NationalParkRepository : INationalParkRepository
    {
        public bool CreateNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }

        public NationalPark GetNationalPark(int nationalParkId)
        {
            throw new NotImplementedException();
        }

        public ICollection<NationalPark> GetNationalParks()
        {
            throw new NotImplementedException();
        }

        public bool NationalParkExists(int nationalParkId)
        {
            throw new NotImplementedException();
        }

        public bool NationalParkExists(string nationalParkName)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            throw new NotImplementedException();
        }
    }
}
