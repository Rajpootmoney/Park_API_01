using Park_API_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Park_API_01.Repository.IRepository
{
    public interface INationalParkRepository
    {
        ICollection<NationalPark> GetNationalParks();  //For Display
        NationalPark GetNationalPark(int nationalParkId);  //For Find
        bool NationalParkExists(int nationalParkId);  //To Check if it Exists Or Not
        bool NationalParkExists(string nationalParkName);  //To Check if it Exists Or Not
        bool CreateNationalPark(NationalPark nationalPark);  //To Create New
        bool UpdateNationalPark(NationalPark nationalPark);  //To Update
        bool DeleteNationalPark(NationalPark nationalPark);  //To Delete
        bool Save();

    }
}
